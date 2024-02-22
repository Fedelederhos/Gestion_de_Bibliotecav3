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
using Gestion_de_Bibliotecav3.DTOs.LibroDTOs;


namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    public partial class GestionLibroForm : Form
    {
        Controlador_Libro controladorLibro = new Controlador_Libro();
        public GestionLibroForm()
        {
            InitializeComponent();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = textBusqueda.Text;

            List<LibroDTO> libroDTOs = controladorLibro.BuscarLibrosPorIsbnONombreConBD(busqueda);
            
            cargarTabla(libroDTOs);
        }

        /// <summary>
        /// Carga la tabla con los libros encontrados.
        /// </summary>
        /// <param name="lista">La lista de libros a cargar.</param>
        private void cargarTabla(List<LibroDTO> lista)
        {
            gridLibros.DataSource = lista;
        }
    }
}
