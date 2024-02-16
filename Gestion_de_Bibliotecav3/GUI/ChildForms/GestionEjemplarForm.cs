using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_de_Bibliotecav3.Controladores;
using Gestion_de_Bibliotecav3.Dominio;


namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    public partial class GestionEjemplarForm : Form
    {
        ControladorEjemplar controladorEjemplar = new ControladorEjemplar();
        Ejemplar ejemplar;
        public GestionEjemplarForm()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            AltaEjemplarForm altaEjemplarForm = new AltaEjemplarForm();
            altaEjemplarForm.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ModificarEjemplarForm modificarEjemplarForm = new ModificarEjemplarForm(ejemplar);
            modificarEjemplarForm.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            controladorEjemplar.EliminarEjemplar(ejemplar);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //busqueda de ejemplares por código
        }

        private void gridEjemplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila clickeada
                DataGridViewRow filaSeleccionada = gridEjemplar.Rows[e.RowIndex];
                string isbn = filaSeleccionada.Cells[1].Value.ToString();
                string nombre = filaSeleccionada.Cells[2].Value.ToString();
                string fechaPublicacion = filaSeleccionada.Cells[3].Value.ToString();
                string codigo = filaSeleccionada.Cells[4].Value.ToString();
                Libro libro = new Libro(isbn, nombre, fechaPublicacion);
                ejemplar = new Ejemplar(int.Parse(codigo), libro);
            }
        }
    }
}
