using Gestion_de_Bibliotecav3.Controladores;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.PrestamoDTOs;
using Gestion_de_Bibliotecav3.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    /// <summary>
    /// Formulario para gestionar préstamos.
    /// </summary>
    public partial class GestionPrestamoForm : Form
    {
        // DTO para manejar información de préstamos.
        private PrestamoDTO prestamo;

        // Controlador para la gestión de préstamos.
        private ControladorPrestamo controladorPrestamo = new ControladorPrestamo();

        // Variables para almacenar información de préstamos.
        private string idPrestamo;
        private string codigoEjemplar;

        /// <summary>
        /// Constructor de la clase GestionPrestamoForm.
        /// </summary>
        public GestionPrestamoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Abre el formulario para registrar un nuevo préstamo.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            NuevoPrestamoForm nuevoPrestamoForm = new NuevoPrestamoForm();
            nuevoPrestamoForm.ShowDialog();
        }

        /// <summary>
        /// Elimina el préstamo seleccionado.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Llama al controlador para eliminar el préstamo.
                controladorPrestamo.EliminarPrestamo(prestamo);
            }
            catch (SystemException s)
            {
                // Muestra un mensaje de error si algún parámetro está mal.
                PopUpForm popup = new PopUpForm("Error en los parámetros");
                popup.ShowDialog();
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error general.
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Busca préstamos por código o DNI.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Realiza la búsqueda y carga los resultados en la tabla.
                string busqueda = textBusqueda.Text;
                List<PrestamoDTO> lista = controladorPrestamo.BuscarPrestamosPorCodigoODNI(busqueda);
                cargarTabla(lista);
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si se produce una excepción.
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Se ejecuta al hacer clic en una celda de la tabla de préstamos.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void gridPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Obtiene el préstamo seleccionado.
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow filaSeleccionada = gridPrestamos.Rows[e.RowIndex];
                    idPrestamo = filaSeleccionada.Cells[0].Value.ToString();
                    prestamo = controladorPrestamo.BuscarPrestamoPorID(int.Parse(idPrestamo));
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si se produce una excepción.
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Carga la tabla con los préstamos obtenidos.
        /// </summary>
        /// <param name="lista">La lista de préstamos a cargar.</param>
        private void cargarTabla(List<PrestamoDTO> lista)
        {
            gridPrestamos.DataSource = lista;
        }
    }
}
