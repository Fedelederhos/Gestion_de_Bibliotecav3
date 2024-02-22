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
    /// Pantalla de gestionar categoria
    /// </summary>
    public partial class ConsultaCategoriaForm : Form
    {
        ControladorEjemplar controladorEjemplar = new ControladorEjemplar();
        public ConsultaCategoriaForm()
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
                List<BuscarEjemplarDTO> lista = new List<BuscarEjemplarDTO>();
                ///lista = controladorEjemplar.BuscarCategorias(busqueda);
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
        private void cargarTabla(List<BuscarEjemplarDTO> lista)
        {
            categoriasGrid.DataSource = lista;
        }
    }
}
