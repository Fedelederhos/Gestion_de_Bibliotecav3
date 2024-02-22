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
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.AutorDTOs;
using Gestion_de_Bibliotecav3.DTOs.CategoriaDTOs;
using Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs;
using Gestion_de_Bibliotecav3.DTOs.LibroDTOs;
using Gestion_de_Bibliotecav3.GUI;
using Gestion_de_Bibliotecav3.Servicios;

namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    /// <summary>
    /// Formulario para la alta de ejemplares.
    /// </summary>
    public partial class AltaEjemplarForm : Form
    {
        // DTO para manejar información de libros.
        private LibroDTO libro = new LibroDTO();

        // Controlador para la gestión de ejemplares.
        private ControladorEjemplar controladorEjemplar = new ControladorEjemplar();

        // Controlador para la gestión de libros.
        private Controlador_Libro controladorLibro = new Controlador_Libro();

        /// <summary>
        /// Constructor de la clase AltaEjemplarForm.
        /// </summary>
        public AltaEjemplarForm()
        {
            InitializeComponent();
            // Configuraciones adicionales para la ventana.
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // Métodos externos para permitir el arrastre de la ventana.
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Eventos de arrastre para la ventana.
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

        /// <summary>
        /// Cierra la ventana.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Acepta el DTO y llama al controlador para crear el ejemplar.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear ejemplar DTO.
                string codigo = boxCodigo.Text;
                CrearEjemplarDTO ejemplarDTO = new CrearEjemplarDTO();
                ejemplarDTO.Libro = libro;
                ejemplarDTO.Codigo = codigo;
                // Llamar al controlador para crear el ejemplar.
                controladorEjemplar.CrearEjemplar(ejemplarDTO);
            }
            catch (SystemException s)
            {
                // Mostrar un mensaje de error si algún parámetro está mal.
                PopUpForm popup = new PopUpForm("Error en los parámetros");
                popup.ShowDialog();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error general.
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
            }
        }

        /// <summary>
        /// Busca el libro a asociar al ejemplar.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string isbnONombre = boxISBNoNombre.Text;
                List<LibroDTO> lista;
                Task<List<LibroDTO>> lista2;
                lista = controladorLibro.BuscarLibrosPorIsbnONombreConBD(isbnONombre);
                if (lista != null)
                {
                    cargarTabla(lista);
                }
                else if (lista == null)
                {
                    lista2 = controladorLibro.BuscarLibrosPorIsbnONombreConApi(isbnONombre);
                    cargarTabla(lista2);
                }
                else { lista = null; }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si se produce una excepción.
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
            }
        }

        /// <summary>
        /// Método que se ejecuta al seleccionar un libro en la tabla.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void gridEjemplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila clickeada.
                DataGridViewRow filaSeleccionada = gridEjemplar.Rows[e.RowIndex];
                // Obtener información del libro seleccionado.
                string isbn = filaSeleccionada.Cells[0].Value.ToString();
                string nombre = filaSeleccionada.Cells[1].Value.ToString();
                string autor = filaSeleccionada.Cells[2].Value.ToString();
                string fechaPublicacion = filaSeleccionada.Cells[3].Value.ToString();
                string categoria = filaSeleccionada.Cells[4].Value.ToString();
                // Crear el DTO del libro.
                libro.ISBN = isbn;
                libro.Nombre = nombre;
                libro.FechaPublicacion = fechaPublicacion;
                AutorDTO autorDTO = new AutorDTO();
                autorDTO.Nombre = autor;
                ICollection<AutorDTO> autorDTOs = new List<AutorDTO>();
                autorDTOs.Add(autorDTO);
                libro.Autores = autorDTOs;
                CategoriaDTO categoriaDTO = new CategoriaDTO();
                categoriaDTO.Nombre = categoria;
                ICollection<CategoriaDTO> categoriaDTOs = new List<CategoriaDTO>();
                categoriaDTOs.Add(categoriaDTO);
                libro.Categorias = categoriaDTOs;
            }
        }

        /// <summary>
        /// Carga la tabla con los libros encontrados.
        /// </summary>
        /// <param name="lista">La lista de libros a cargar.</param>
        private void cargarTabla(List<LibroDTO> lista)
        {
            gridEjemplar.DataSource = lista;
        }

        /// <summary>
        /// Carga la tabla con los libros encontrados.
        /// </summary>
        /// <param name="lista">La tarea que devuelve la lista de libros.</param>
        private void cargarTabla(Task<List<LibroDTO>> lista)
        {
            gridEjemplar.DataSource = lista;
        }
    }
}

