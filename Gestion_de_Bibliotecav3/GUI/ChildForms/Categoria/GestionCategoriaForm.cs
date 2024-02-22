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

namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    /// <summary>
    /// Pantalla de gestionar categoria
    /// </summary>
    public partial class GestionCategoriaForm : Form
    {
        ControladorCategoria controladorCategoria = new ControladorCategoria();
        public GestionCategoriaForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Busca por categoria por coincidencia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = textBusqueda.Text;
                List<Categoria> lista = new List<Categoria>();
                lista = controladorCategoria.BuscarCategoriasPorCoincidencia(busqueda);
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
        /// Carga en la tabla los resultados de la búsqueda
        /// </summary>
        /// <param name="lista"></param>
        private void cargarTabla(List<Categoria> lista)
        {
            categoriasGrid.DataSource = lista;
        }
    }
}
