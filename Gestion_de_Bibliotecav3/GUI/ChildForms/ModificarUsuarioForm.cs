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
using Gestion_de_Bibliotecav3.Controladores;

namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    public partial class ModificarUsuarioForm : Form
    {
        public Usuario usuario { get; set; }
        ControladorUsuario controladorUsuario = new ControladorUsuario();

        public ModificarUsuarioForm(Usuario usuario)
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.usuario = usuario;
            this.textBoxDNI.Text = usuario.DNI.ToString();
            this.textBoxNombre.Text = usuario.Nombre;
            this.textBoxDireccion.Text = usuario.Direccion;
            this.textBoxEmail.Text = usuario.Email; 
            this.textBoxTelefono.Text = usuario.Telefono.ToString();

        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

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
            string dni = textBoxDNI.Text;
            string nombre = textBoxNombre.Text;
            string direccion = textBoxDireccion.Text;
            string telefono = textBoxTelefono.Text;
            string email = textBoxEmail.Text;
            //Usuario usuarioOriginal = new Usuario();
            //usuarioOriginal = controladorUsuario.obtenerUsuario(dni)[0];
            Usuario usuarioNuevo = new Usuario(int.Parse(dni), nombre, direccion, int.Parse(telefono),email);
            controladorUsuario.ModificarUsuario(usuario);
        }
    }
}
