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
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.GUI;


namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    /// <summary>
    /// Pantalla de gestion de ejemplar principal
    /// </summary>
    public partial class GestionEjemplarForm : Form
    {
        ControladorEjemplar controladorEjemplar = new ControladorEjemplar();
        Ejemplar ejemplar;
        public GestionEjemplarForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botón que lleva a la pantalla de crear un ejemplar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            AltaEjemplarForm altaEjemplarForm = new AltaEjemplarForm();
            altaEjemplarForm.ShowDialog();
        }

        /// <summary>
        /// Botón que lleva a la pantalla de modificar ejemplar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ModificarEjemplarForm modificarEjemplarForm = new ModificarEjemplarForm(ejemplar);
            modificarEjemplarForm.ShowDialog();
        }

        /// <summary>
        /// Botón que a partir del ejemplar seleccionado crea el DTO y llama al controlador para eliminar el Ejemplar seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                controladorEjemplar.EliminarEjemplar(ejemplar);
                // Mensaje de exito
            }
            catch (SystemException s)
            {
                // Algun parametro esta mal (id o no existe)
                PopUpForm popup = new PopUpForm("Error en los parametros");
                popup.ShowDialog();
            }
            catch (Exception e)
            {
                // Se debe mostrar este error "e.Message.ToString()"
                PopUpForm popup = new PopUpForm(e.ToString());
                popup.ShowDialog();
                Console.WriteLine(e.Message);

            }
        }

        /// <summary>
        /// Botón que llama al controlador para buscar el Ejemplar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = textBusqueda.Text;
                List<Ejemplar> lista;
                lista = controladorEjemplar.BuscarEjemplaresPorIsbnONombre(busqueda);
                cargarTabla(lista);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
            } 
        }

        /// <summary>
        /// Método que permite seleccionar un Ejemplar de la tabla y crea el DTO correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridEjemplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila clickeada
                DataGridViewRow filaSeleccionada = gridEjemplar.Rows[e.RowIndex];
                string isbn = filaSeleccionada.Cells[1].Value.ToString();
                string nombre = filaSeleccionada.Cells[2].Value.ToString();
                string fechaPublicacion = filaSeleccionada.Cells[3].Value.ToString();
                string codigo = filaSeleccionada.Cells[4].Value.ToString();
                Libro libro = new Libro(isbn, nombre, fechaPublicacion);
                ejemplar = new Ejemplar(codigo, libro);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lista"></param>
        private void cargarTabla(List<Ejemplar> lista)
        {
            gridEjemplar.DataSource = lista;
        }
    }
}
