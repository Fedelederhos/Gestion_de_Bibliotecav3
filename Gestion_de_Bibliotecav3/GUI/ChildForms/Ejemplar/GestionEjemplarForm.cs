using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_de_Bibliotecav3.Controladores;
using Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs;
using Gestion_de_Bibliotecav3.GUI;
using Gestion_de_Bibliotecav3.Servicios;

namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    /// <summary>
    /// Formulario principal para gestionar ejemplares.
    /// </summary>
    public partial class GestionEjemplarForm : Form
    {
        // Controlador para la gestión de ejemplares.
        private ControladorEjemplar controladorEjemplar = new ControladorEjemplar();

        // DTO para manejar información de ejemplares.
        private BuscarEjemplarDTO ejemplar = new BuscarEjemplarDTO();

        /// <summary>
        /// Constructor de la clase GestionEjemplarForm.
        /// </summary>
        public GestionEjemplarForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que lleva a la pantalla de crear un ejemplar.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            AltaEjemplarForm altaEjemplarForm = new AltaEjemplarForm();
            altaEjemplarForm.ShowDialog();
        }

        /// <summary>
        /// Evento que elimina el ejemplar seleccionado.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el código del ejemplar seleccionado.
                string codigo = ejemplar.codigo;
                // Crear DTO para eliminar ejemplar.
                EliminarEjemplarDTO eliminarEjemplarDTO = new EliminarEjemplarDTO();
                eliminarEjemplarDTO.codigo = codigo;
                // Llamar al controlador para eliminar el ejemplar.
                controladorEjemplar.EliminarEjemplar(eliminarEjemplarDTO);
            }
            catch (SystemException s)
            {
                // Mostrar un mensaje de error si algún parámetro está mal.
                PopUpForm popup = new PopUpForm("Error en los parámetros");
                popup.ShowDialog();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error general.
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Evento que busca ejemplares por ISBN o nombre.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el texto de búsqueda.
                string busqueda = textBusqueda.Text;
                // Buscar ejemplares por ISBN o nombre.
                List<BuscarEjemplarDTO> lista = controladorEjemplar.BuscarEjemplaresPorIsbnONombre(busqueda);
                // Cargar los resultados en la tabla.
                cargarTabla(lista);
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si se produce una excepción.
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
            }
        }

        /// <summary>
        /// Método que permite seleccionar un ejemplar de la tabla y crea el DTO correspondiente.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void gridEjemplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila clickeada.
                DataGridViewRow filaSeleccionada = gridEjemplar.Rows[e.RowIndex];
                // Obtener información del ejemplar seleccionado.
                string isbn = filaSeleccionada.Cells[0].Value.ToString();
                string nombre = filaSeleccionada.Cells[1].Value.ToString();
                string fechaPublicacion = filaSeleccionada.Cells[2].Value.ToString();
                string codigo = filaSeleccionada.Cells[3].Value.ToString();
                string fechaAlta = filaSeleccionada.Cells[4].Value.ToString();
                string fechaBaja = filaSeleccionada.Cells[5].Value.ToString();
                string disponibilidad = filaSeleccionada.Cells[6].Value.ToString();
                // Crear el DTO del ejemplar.
                ejemplar.codigo = codigo;
                ejemplar.nombre = nombre;
                ejemplar.isbn = isbn;
                ejemplar.añoPublicacion = fechaPublicacion;
                ejemplar.fechaAlta = fechaAlta;
                ejemplar.fechaBaja = fechaBaja;
                ejemplar.disponibilidad = disponibilidad;
            }
        }

        /// <summary>
        /// Cargar los resultados de la búsqueda en la tabla.
        /// </summary>
        /// <param name="lista">La lista de ejemplares a cargar.</param>
        private void cargarTabla(List<BuscarEjemplarDTO> lista)
        {
            // Establecer la lista como fuente de datos del DataGridView.
            gridEjemplar.DataSource = lista;
        }
    }
}
