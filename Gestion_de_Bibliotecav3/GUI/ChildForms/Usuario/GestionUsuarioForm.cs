using Gestion_de_Bibliotecav3.Controladores;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.PrestamoDTOs;
using Gestion_de_Bibliotecav3.DTOs.UsuarioDTOs;
using Gestion_de_Bibliotecav3.GUI;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    public partial class GestionUsuarioForm : Form
    {
        BuscarUsuarioDTO usuario = new BuscarUsuarioDTO();
        private ControladorUsuario controladorUsuario = new ControladorUsuario();
        private string dni2;
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
      
            ModificarUsuarioForm modificarUsuarioForm = new ModificarUsuarioForm(usuario);
            modificarUsuarioForm.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                controladorUsuario.Eliminar(dni2);
            }
            catch (SystemException s)
            {
                PopUpForm popup = new PopUpForm("Error en los parametros");
                popup.ShowDialog();
                //La panntalla deberia mostrar que algun parametro esta mal
            }
            catch (Exception ex)
            {
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
                Console.WriteLine(ex.Message);

            }
        }

        private void gridUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila clickeada
                DataGridViewRow filaSeleccionada = gridUsuario.Rows[e.RowIndex];
                int dni = int.Parse(filaSeleccionada.Cells[0].Value.ToString());
                dni2 = filaSeleccionada.Cells[0].Value.ToString();
                string nombre = filaSeleccionada.Cells[0].Value.ToString();
                string direccion = filaSeleccionada.Cells[0].Value.ToString();
                int telefono = int.Parse(filaSeleccionada.Cells[0].Value.ToString());
                string email = filaSeleccionada.Cells[0].Value.ToString();
                usuario.DNI = dni;
                usuario.Nombre = nombre;
                usuario.Direccion = direccion;
                usuario.Telefono = telefono;
                usuario.Email = email;
            }
        }

        private void cargarTabla(List<BuscarUsuarioDTO> lista)
        {
            gridUsuario.DataSource = lista;
        }
    }
}

