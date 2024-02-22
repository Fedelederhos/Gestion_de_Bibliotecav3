using Gestion_de_Biblioteca.GUI.ChildForms;
using Gestion_de_Bibliotecav3.Controladores;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.GUI;
using MySqlX.XDevAPI.Relational;
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



namespace Gestion_de_Biblioteca
{
    public partial class MenuPrincipal : Form
    {
        ControladorPrestamo controladorPrestamo = new ControladorPrestamo();
        //fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form ActiveForm;
        //constructor
        public MenuPrincipal()
        {
            InitializeComponent();
            random = new Random();
            buttonCloseChildForm.Visible = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Load += CargarTabla;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
        }

        //Metodos
        private void CargarTabla(object? sender, EventArgs e)
        {
            try
            {
                List<Prestamo> listaOriginal = new List<Prestamo>();
                listaOriginal = controladorPrestamo.ProximosPrestamosAVencer();
                string isbn;
                string usuario;
                string fechaVencimiento;
                foreach (Prestamo prestamo in listaOriginal)
                {
                    isbn = prestamo.Ejemplar.Libro.ISBN;
                    usuario = prestamo.Usuario.DNI.ToString();
                    fechaVencimiento = prestamo.FechaVencimiento.ToString();
                    dataGrid.Rows.Add(isbn, usuario, fechaVencimiento);
                }
            }
            catch (Exception ex)
            {
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                Console.WriteLine(ex.Message);
            }
        }
        private Color SeleccionarColor()
        {
            int index = random.Next(Colores.ListaColores.Count);
            while (tempIndex == index)
            {
                index = random.Next(Colores.ListaColores.Count); //si el color ya fue seleccionado elegimos otro
            }
            tempIndex = index;
            string color = Colores.ListaColores[index];
            return ColorTranslator.FromHtml(color);
        }

        //"Resalta" el boton que ha sido seleccionado, eligiendo un color random,
        // También se cambia la fuente y el tamaño del botón
        private void ActivarColor(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DeshabilitarColor();
                    Color color = SeleccionarColor();
                    Color secondColor = Colores.ChangeColorBrightness(color, -0.3);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelBaner.BackColor = secondColor;
                }
            }
        }

        //desactivar el resaltado del boton a valores default
        private void DeshabilitarColor()
        {
            foreach (Control btnPrevio in panelMenu.Controls)
            {
                if (btnPrevio.GetType() == typeof(Button))
                {
                    btnPrevio.BackColor = Color.FromArgb(37, 52, 57);
                    btnPrevio.ForeColor = Color.Gainsboro;
                    btnPrevio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();

            }
            ActivarColor(btnSender);
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            labelTitulo.Text = childForm.Text;
            childForm.Show();
            buttonCloseChildForm.Visible = true;
        }

        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            // OpenChildForm(new GUI.ChildForms.NuevoPrestamoForm(), sender);
            ActivarColor(sender);
            NuevoPrestamoForm nuevoPrestamo = new NuevoPrestamoForm();
            nuevoPrestamo.ShowDialog();
        }

        private void btnGestionUsuario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.ChildForms.GestionUsuarioForm(), sender);
        }

        private void btnGestionPrestamos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.ChildForms.GestionPrestamoForm(), sender);
        }

        private void btnGestionEjemplares_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.ChildForms.GestionEjemplarForm(), sender);
        }

        private void btnGestionAutores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.ChildForms.GestionAutorForm(), sender);
        }

        private void btnGestionCategorias_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.ChildForms.GestionCategoriaForm(), sender);
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            ActivarColor(sender);
            RegistrarDevolucionForm registrarDevolucionForm = new RegistrarDevolucionForm();
            registrarDevolucionForm.ShowDialog();
        }

        private void btnGestionLibros_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.ChildForms.GestionLibroForm(), sender);
        }

        private void MenuPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else { this.WindowState = FormWindowState.Normal; }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBaner_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelDesktop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonCloseChildForm_Click(object sender, EventArgs e)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
                Reset();
            }
        }
        private void Reset()
        {
            DeshabilitarColor();
            labelTitulo.Text = "Próximos Vencimientos";
            panelBaner.BackColor = Color.FromArgb(37, 52, 57);
            currentButton = null;
            buttonCloseChildForm.Visible = false;
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /* private void cargarMaquinaria()
         {

             List<PrestamoLibro> listaPrestamos = controladorPrestamos.ListarPrestamos();

             foreach (PrestamoLibro prestamo in listaPrestamos)
             {
                 string estado = prestamo.Estado ? "En Préstamo" : "Devuelto";
                 string[] fila = {
             prestamo.Id.ToString(),
             prestamo.CodigoLibro.ToString(),
             prestamo.NombreLibro,
             prestamo.NombreUsuario,
             prestamo.FechaPrestamo.ToString(),
             prestamo.FechaDevolucion.HasValue ? prestamo.FechaDevolucion.Value.ToString() : "No devuelto",
             estado
         };

                 // Suponiendo que dataGridViewLibros tiene las columnas necesarias creadas
                 dataGridViewLibros.Rows.Add(fila);
             }*/
    }

    /*
     * public void cargarMaquinaria(){
    DefaultTableModel modeloTablaMaquinaria = (DefaultTableModel) table.getModel();
    modeloTablaMaquinaria.setRowCount(0);
    List<Maquinaria> filasTablaEmpleado = controladorMaquinaria.listarMaquinaria();
    Iterator<Maquinaria> iterador = filasTablaEmpleado.iterator();
    while (iterador.hasNext()) {
        Maquinaria maquinaria = (Maquinaria) iterador.next();
        String estado = maquinaria.getEstado() ? "En Servicio" : "Fuera De Servicio";
        String fila[] = {String.valueOf(maquinaria.getId()),String.valueOf(maquinaria.getCodigo()),String.valueOf(maquinaria.getDescripcion()),
                String.valueOf(maquinaria.getFabricante()),String.valueOf(maquinaria.getUbicacionAlmacenamiento()),String.valueOf(estado),
    };
        modeloTablaMaquinaria.addRow(fila);
    }	
}
    public void actualizarTabla() {
     DefaultTableModel modelo = (DefaultTableModel) table.getModel();
        modelo.setRowCount(0); // Limpia la tabla
        cargarMaquinaria();
}
     * 
     */


}

