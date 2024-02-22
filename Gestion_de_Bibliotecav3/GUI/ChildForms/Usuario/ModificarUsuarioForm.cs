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
using Gestion_de_Bibliotecav3.GUI;
using Gestion_de_Bibliotecav3.DTOs.UsuarioDTOs;

namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    public partial class ModificarUsuarioForm : Form
    {
        public BuscarUsuarioDTO usuario { get; set; }
        ControladorUsuario controladorUsuario = new ControladorUsuario();

        public ModificarUsuarioForm(BuscarUsuarioDTO usuario)
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
            try
            {
                string dni = textBoxDNI.Text;
                string nombre = textBoxNombre.Text;
                string direccion = textBoxDireccion.Text;
                string telefono = textBoxTelefono.Text;
                string email = textBoxEmail.Text;
                UsuarioDTO usuarioNuevo = new UsuarioDTO();
                usuarioNuevo.DNI = int.Parse(dni);
                usuarioNuevo.Nombre = nombre;
                usuarioNuevo.Direccion = direccion;
                usuarioNuevo.Telefono = int.Parse(telefono);
                usuarioNuevo.Email = email;
                controladorUsuario.ModificarUsuario(usuarioNuevo);
            }
            catch (SystemException s)
            {
                //La panntalla deberia mostrar que algun parametro esta mal
                PopUpForm popup = new PopUpForm("Error en los parametros");
                popup.ShowDialog();
            }
            catch (Exception ex)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                Console.WriteLine(ex.Message);
            }
        }
    }
}
