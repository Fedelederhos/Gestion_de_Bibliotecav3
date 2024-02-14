using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    public partial class GestionPrestamoForm : Form
    {
        public GestionPrestamoForm()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            NuevoPrestamoForm nuevoPrestamoForm = new NuevoPrestamoForm();
            nuevoPrestamoForm.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string id = obtenerSeleccionado(sender, e);
            //método eliminar
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //busqueda
            //Cargar en la tabla
        }
        private string obtenerSeleccionado(object sender, EventArgs e)
        {
            string cell = null;
            // Verificar si hay al menos una fila seleccionada
            if (gridPrestamos.SelectedRows.Count > 0)
            {
                // Obtener la primera fila seleccionada (puedes ajustarlo según tus necesidades)
                DataGridViewRow selectedRow = gridPrestamos.SelectedRows[0];

                // Obtener el valor de una celda específica (por ejemplo, la primera celda en este caso)
                object cellValue = selectedRow.Cells["id"].Value;

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