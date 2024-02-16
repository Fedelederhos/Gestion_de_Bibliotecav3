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

namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    public partial class GestionAutorForm : Form
    { 
        ControladorAutor controladorAutor = new ControladorAutor();
        public GestionAutorForm()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        { 
            List<Autor> lista = new List<Autor>();
            lista = controladorAutor.BuscarAutoresPorCoincidencia(textBusqueda.Text);
            cargarTabla(lista);
        }

        private void cargarTabla(List<Autor> lista)
        {
            autorDataGrid.DataSource = lista;
        }
    }
}
