using Gestion_de_Bibliotecav3.Controladores;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.GUI;
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
    public partial class NuevoPrestamoForm : Form
    {
        ControladorEjemplar controladorEjemplar = new ControladorEjemplar();
        ControladorUsuario controladorUsuario = new ControladorUsuario();
        ControladorPrestamo controladorPrestamo = new ControladorPrestamo();
        Ejemplar ejemplar;
        string codigoEjemplar;
        Usuario usuario;
        List<Usuario> listaUsuario;
        public NuevoPrestamoForm()
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Ejemplar> list = new List<Ejemplar>();
                list = controladorEjemplar.BuscarEjemplaresPorIsbnONombre(textBox1.Text);
                cargarTabla(list);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = usuario.DNI;
                controladorPrestamo.NuevoPrestamo(ejemplar, usuario, (DateTime)controladorPrestamo.AsignarVencimiento(dni));
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
            }
        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            string dni = textBoxDNI.Text;
            listaUsuario = controladorUsuario.obtenerUsuario(dni);
            usuario = listaUsuario[0];
        }

        private void gridEjemplares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila clickeada
                    DataGridViewRow filaSeleccionada = gridEjemplares.Rows[e.RowIndex];
                    string id = filaSeleccionada.Cells[0].Value.ToString();
                    ejemplar = controladorEjemplar.BuscarEjemplarPorID(int.Parse(id));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
            }   
        }

        private void cargarTabla(List<Ejemplar> lista)
        {
            gridEjemplares.DataSource = lista;
        }
    }
}

