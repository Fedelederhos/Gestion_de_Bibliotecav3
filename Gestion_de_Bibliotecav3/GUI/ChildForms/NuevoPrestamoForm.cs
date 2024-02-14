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
            //metodo de buscar
            //metodo de cargar resultado en la tabka
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string codigo = obtenerSeleccionado(sender, e);
            string dni = textBoxDNI.Text;
            // guardar nuevo prestamo
        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            //mostrar que el dni es válido
        }
        private string obtenerSeleccionado(object sender, EventArgs e)
        {
            string cell = null;
            // Verificar si hay al menos una fila seleccionada
            if (gridEjemplares.SelectedRows.Count > 0)
            {
                // Obtener la primera fila seleccionada (puedes ajustarlo según tus necesidades)
                DataGridViewRow selectedRow = gridEjemplares.SelectedRows[0];

                // Obtener el valor de una celda específica (por ejemplo, la primera celda en este caso)
                object cellValue = selectedRow.Cells["codigo"].Value;

                // Verificar si la celda tiene un valor antes de usarlo
                if (cellValue == null)
                {
                    MessageBox.Show("La celda seleccionada está vacía.");
                }
                cell = cellValue.ToString();
            }
            return cell;
        }
    }
}

