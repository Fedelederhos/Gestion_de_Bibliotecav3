using Gestion_de_Bibliotecav3.Controladores;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.GUI;
using Gestion_de_Bibliotecav3.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_de_Bibliotecav3.DTOs;
using Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs;

namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    /// <summary>
    /// Formulario para consultar y gestionar categorías de ejemplares.
    /// </summary>
    public partial class ConsultaCategoriaForm : Form
    {
        // Controlador para la gestión de ejemplares.
        private ControladorEjemplar controladorEjemplar = new ControladorEjemplar();

        /// <summary>
        /// Constructor de la clase ConsultaCategoriaForm.
        /// </summary>
        public ConsultaCategoriaForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se desencadena al hacer clic en el botón de búsqueda.
        /// Busca ejemplares por categoría coincidente con el texto de búsqueda.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el texto de búsqueda del TextBox.
                string busqueda = textBusqueda.Text;
                // Buscar ejemplares por categoría coincidente con el texto de búsqueda.
                List<BuscarEjemplarDTO> lista = controladorEjemplar.BuscarEjemplaresPorCategoriasPorCoincidencia(busqueda);
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
        /// Cargar los resultados de la búsqueda en la tabla de categorías.
        /// </summary>
        /// <param name="lista">La lista de ejemplares a cargar en la tabla.</param>
        private void cargarTabla(List<BuscarEjemplarDTO> lista)
        {
            // Establecer la lista como fuente de datos del DataGridView.
            categoriasGrid.DataSource = lista;
        }
    }
}

