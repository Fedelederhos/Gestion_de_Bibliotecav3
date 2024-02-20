using Gestion_de_Bibliotecav3.Controladores;
using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    public partial class RegistrarDevolucionForm : Form
    {
        ControladorPrestamo controladorPrestamo = new ControladorPrestamo();
        ControladorEjemplar controladorEjemplar = new ControladorEjemplar();
        public RegistrarDevolucionForm()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBanner_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelCampos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelBotones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            
            string estado;
            string codigo;
            estado = estadoComboBox.SelectedItem.ToString();
            codigo = codigoLabel.Text;

            controladorPrestamo.RegistrarDevolucionPrestamo(codigo, ParseEstado(estado));
        }

        private Estado ParseEstado(string estado)
        {
            switch(estado)
            {
                case "Bueno":
                    return Estado.Bueno;
                case "Regular":
                    return Estado.Regular;
                case "Arruinado":
                    return Estado.Arruinado;
                default:
                    throw new ArgumentException("Estado no válido", nameof(estado));
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            bool value;
            //metodo buscar prestamo sin vencer del ejemplar
            value = true; //acá va a haber que asignar ese resultado
            if (value)
            {
                MessageBox.Show("El código ingresado coincide con un ejemplar existente", "Código válido");
            }
            else
            {
                MessageBox.Show("El código ingresado no coincide con un ejemplar existente", "Código no válido");
            }
        }
    }
}
