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
    public partial class GestionLibroForm : Form
    {
        public GestionLibroForm()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            //AltaLibroForm altaLibroForm = new AltaLibroForm();
            //altaLibroForm.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // row selected tomar id 
            // popup realmente quiere elimnar
            // eliminar
            // eliminar exitoso
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // id de label
            // busqueda por id de libros
        }
    }
}
