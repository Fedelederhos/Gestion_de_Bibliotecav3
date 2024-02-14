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
    public partial class GestionEjemplarForm : Form
    {
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
            ModificarEjemplarForm modificarEjemplarForm = new ModificarEjemplarForm();
            modificarEjemplarForm.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string codigo = obtenerSeleccionado(sender, e);
            //método eliminar a partir de un código
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //busqueda de ejemplares por código
        }

        private string obtenerSeleccionado(object sender, EventArgs e)
        {
            string cell = null;
            // Verificar si hay al menos una fila seleccionada
            if (gridEjemplar.SelectedRows.Count > 0)
            {
                // Obtener la primera fila seleccionada (puedes ajustarlo según tus necesidades)
                DataGridViewRow selectedRow = gridEjemplar.SelectedRows[0];

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
