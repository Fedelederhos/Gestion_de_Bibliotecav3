using Gestion_de_Bibliotecav3.Controladores;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs;
using Gestion_de_Bibliotecav3.DTOs.UsuarioDTOs;
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
       private ControladorEjemplar controladorEjemplar = new ControladorEjemplar();
       private ControladorUsuario controladorUsuario = new ControladorUsuario();
       private ControladorPrestamo controladorPrestamo = new ControladorPrestamo();
       private BuscarEjemplarDTO ejemplar = new BuscarEjemplarDTO();
       private string codigoEjemplar;
       private BuscarUsuarioDTO usuarioDTO = new BuscarUsuarioDTO();
        List<BuscarUsuarioDTO> listaUsuario = new List<BuscarUsuarioDTO>();
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
                List<BuscarEjemplarDTO> list = new List<BuscarEjemplarDTO>();
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
                string dni = usuarioDTO.DNI.ToString();
                string fechaVencimientStr = controladorPrestamo.AsignarVencimiento(dni);
                DateTime fechaVencimient = DateTime.Parse(fechaVencimientStr);
                controladorPrestamo.NuevoPrestamo(ejemplar, usuarioDTO, fechaVencimient);
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
            try
            {
                string dni = textBoxDNI.Text;
                listaUsuario = controladorUsuario.ObtenerUsuarioPorNombreODNI(dni);
                usuarioDTO = listaUsuario[0];
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

        private void gridEjemplares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila clickeada
                    DataGridViewRow filaSeleccionada = gridEjemplares.Rows[e.RowIndex];
                    string codigo = filaSeleccionada.Cells[2].Value.ToString();
                    ejemplar = controladorEjemplar.BuscarPorCodigo(codigo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
            }   
        }

        private void cargarTabla(List<BuscarEjemplarDTO> lista)
        {
            gridEjemplares.DataSource = lista;
        }
    }
}

