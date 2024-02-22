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
using Gestion_de_Bibliotecav3.DTOs.AutorDTOs;
using Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs;
using Gestion_de_Bibliotecav3.GUI;
using Gestion_de_Bibliotecav3.Servicios;

namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    /// <summary>
    /// Formulario para consultar ejemplares por autor.
    /// </summary>
    public partial class ConsultaAutorForm : Form
    {
        // Controlador para la gestión de ejemplares.
        private ControladorEjemplar controladorEjemplar = new ControladorEjemplar();

        /// <summary>
        /// Constructor de la clase ConsultaAutorForm.
        /// </summary>
        public ConsultaAutorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se desencadena al hacer clic en el botón de búsqueda.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Buscar los ejemplares por autores que coincidan con la cadena de búsqueda.
                List<BuscarEjemplarDTO> lista = controladorEjemplar.BuscarEjemplaresPorAutoresPorCoincidencia(textBusqueda.Text);
                // Cargar los resultados en la tabla.
                cargarTabla(lista);
            }
            catch (NullReferenceException n)
            {
                // Mostrar un mensaje de error si se produce una excepción de referencia nula.
                PopUpForm popup = new PopUpForm(n.ToString());
                popup.ShowDialog();
                Console.WriteLine(n.Message);
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error general si se produce una excepción.
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
            }
        }

        /// <summary>
        /// Cargar los resultados de la búsqueda en la tabla.
        /// </summary>
        /// <param name="lista">La lista de ejemplares a cargar.</param>
        private void cargarTabla(List<BuscarEjemplarDTO> lista)
        {
            // La propiedad DataSource establece la fuente de datos del DataGridView,
            // lo que significa que mostrará los elementos de la lista en sus filas y columnas.
            autorDataGrid.DataSource = lista;
        }
    }
}
