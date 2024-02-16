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


namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    public partial class GestionLibroForm : Form
    {
       // ControladorLibro controladorLibro = new ControladorLibro();
        public GestionLibroForm()
        {
            InitializeComponent();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = textBusqueda.Text;    

            // busqueda por id de libros
        }
    }
}
