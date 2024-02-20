using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Bibliotecav3.GUI
{
    //Como usar:
    // PopUpForm popup = new PopupForm(mensaje);
    //popup.ShowDialog();
    public partial class PopUpForm : Form
    {
        public PopUpForm(string mensaje)
        {
            InitializeComponent();
            labelMensaje.Text = mensaje;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
