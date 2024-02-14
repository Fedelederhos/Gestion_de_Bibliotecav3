using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    public partial class GestionUsuarioForm : Form
    {
        public GestionUsuarioForm()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            AltaUsuarioForm altaUsuarioForm = new AltaUsuarioForm();
            altaUsuarioForm.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ModificarUsuarioForm modificarUsuarioForm = new ModificarUsuarioForm();
            modificarUsuarioForm.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string dni = obtenerSeleccionado(sender, e);

            //eliminar usuario
        }
        private string obtenerSeleccionado(object sender, EventArgs e)
        {
            string cell = null;
            // Verificar si hay al menos una fila seleccionada
            if (gridUsuario.SelectedRows.Count > 0)
            {
                // Obtener la primera fila seleccionada (puedes ajustarlo según tus necesidades)
                DataGridViewRow selectedRow = gridUsuario.SelectedRows[0];

                // Obtener el valor de una celda específica (por ejemplo, la primera celda en este caso)
                object cellValue = selectedRow.Cells["dni"].Value;

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

