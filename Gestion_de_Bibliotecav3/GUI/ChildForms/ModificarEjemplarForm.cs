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
    public partial class ModificarEjemplarForm : Form
    {
        public Ejemplar ejemplar { get; set; }
        ControladorEjemplar controladorEjemplar = new ControladorEjemplar();
        public ModificarEjemplarForm(Ejemplar ejemplar)
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.ejemplar = ejemplar;
            this.textBoxCodigo.Text = ejemplar.Codigo;
            this.textBoxFechaBaja.Text = ejemplar.FechaBaja.ToShortDateString();
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
            string codigo = textBoxCodigo.Text;
            string fechaBaja = textBoxFechaBaja.Text;
            string disponibilidad = comboBoxDisponibilidad.SelectedText;
            Ejemplar ejemplarOriginal = new Ejemplar();
            ejemplarOriginal = controladorEjemplar.BuscarPorCodigo(codigo);
            Ejemplar ejemplar = new Ejemplar(codigo, ejemplarOriginal.Libro);
            ejemplar.FechaBaja = DateTime.Parse(fechaBaja);
            Boolean dispo;
            if (disponibilidad == "Disponible") { ejemplar.Disponibilidad = true; }
            else if (disponibilidad == "No disponible") { ejemplar.Disponibilidad = false; }
            controladorEjemplar.ModificarEjemplar(ejemplar);
        }
    }
}

