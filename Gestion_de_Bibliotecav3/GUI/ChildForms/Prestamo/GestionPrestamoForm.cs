using Gestion_de_Bibliotecav3.Controladores;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.GUI;
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
        Prestamo prestamo;
        ControladorPrestamo controladorPrestamo = new ControladorPrestamo();
        string idPrestamo;
        string codigoEjemplar;

        public GestionPrestamoForm()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            NuevoPrestamoForm nuevoPrestamoForm = new NuevoPrestamoForm();
            nuevoPrestamoForm.ShowDialog();
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                controladorPrestamo.EliminarPrestamo(prestamo);
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = textBusqueda.Text;
                List<Prestamo> lista = new List<Prestamo> { prestamo };
                lista = controladorPrestamo.BuscarPrestamosPorCodigoODNI(busqueda);
                cargarTabla(lista);
            }
            catch (Exception ex)
            {
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                Console.WriteLine(ex.Message);
            }
        }

        private void gridPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila clickeada
                    DataGridViewRow filaSeleccionada = gridPrestamos.Rows[e.RowIndex];
                    idPrestamo = filaSeleccionada.Cells[0].Value.ToString();
                    codigoEjemplar = filaSeleccionada.Cells[1].Value.ToString();
                    prestamo = controladorPrestamo.BuscarPrestamoPorID(int.Parse(idPrestamo));
                }
            }
            catch (Exception ex)
            {
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                Console.WriteLine(ex.Message);
            }
        }

        private void cargarTabla(List<Prestamo> lista)
        {
            gridPrestamos.DataSource = lista;
        }
    }
}