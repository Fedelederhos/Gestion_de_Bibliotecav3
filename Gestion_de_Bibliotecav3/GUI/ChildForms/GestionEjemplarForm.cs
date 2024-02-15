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
    public partial class GestionEjemplarForm : Form
    {
        public GestionEjemplarForm()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            AltaEjemplarForm altaEjemplarForm = new AltaEjemplarForm();
            altaEjemplarForm.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ModificarEjemplarForm modificarEjemplarForm = new ModificarEjemplarForm();
            modificarEjemplarForm.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            
            //método eliminar a partir de un código
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //busqueda de ejemplares por código
        }

    }
}
