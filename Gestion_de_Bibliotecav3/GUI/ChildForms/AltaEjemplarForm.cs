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
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.Controladores;
using Gestion_de_Bibliotecav3.GUI;
using Gestion_de_Bibliotecav3.Servicios;

namespace Gestion_de_Biblioteca.GUI.ChildForms
{/// <summary>
/// Alta de Ejemplares, se crea a partir del codigo de ejemplar y la seleccion de un libro
/// </summary>
    public partial class AltaEjemplarForm : Form
    {
        Libro libro;
        ControladorEjemplar controladorEjemplar = new ControladorEjemplar();
        Controlador_Libro controladorLibro = new Controlador_Libro();
        public AltaEjemplarForm()
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
        //Métodos


        /// <summary>
        /// Cierra la venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Acepta el DTO y llama al controlador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
           string codigo = boxCodigo.Text;
            Ejemplar ejemplar = new Ejemplar(codigo, libro);
            controladorEjemplar.CrearEjemplar(ejemplar);
        }

        /// <summary>
        /// Busca el Libro a asociar al Ejemplar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
                try
                {
                    string isbnONombre = boxISBNoNombre.Text;
                    List<Libro> lista;
                    lista = controladorLibro.BuscarLibroPorNombreOISBN(isbnONombre);
                    cargarTabla(lista);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    PopUpForm popup = new PopUpForm(ex.ToString());
                    popup.ShowDialog();
                }
            
        }

        /// <summary>
        /// Método para seleccionar un libro en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridEjemplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila clickeada
                DataGridViewRow filaSeleccionada = gridEjemplar.Rows[e.RowIndex];
                string isbn = filaSeleccionada.Cells[0].Value.ToString();
                string nombre = filaSeleccionada.Cells[0].Value.ToString();
                string fechaPublicacion = filaSeleccionada.Cells[0].Value.ToString();
                libro = new Libro(isbn, nombre, fechaPublicacion);
            }
        }

        /// <summary>
        /// Método que carga el DTO en la tabla de Libros
        /// </summary>
        /// <param name="lista"></param>
        private void cargarTabla(List<Libro> lista)
        {
            gridEjemplar.DataSource = lista;
        }
    }
}
