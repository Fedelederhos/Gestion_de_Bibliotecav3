using Gestion_de_Bibliotecav3.Controladores;
using Gestion_de_Bibliotecav3.Dominio;
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
        ControladorPrestamos controladorPrestamos = new ControladorPrestamos();
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
            controladorPrestamos.EliminarPrestamo(prestamo);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = textBusqueda.Text;
            controladorPrestamos.BuscarPrestamos(busqueda);
        }

        private void gridPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila clickeada
                DataGridViewRow filaSeleccionada = gridPrestamos.Rows[e.RowIndex];
                idPrestamo = filaSeleccionada.Cells[0].Value.ToString();
                codigoEjemplar = filaSeleccionada.Cells[1].Value.ToString();
                // CAMBIAR POR EL METODO DE BUSQUEDA DE PRESTAMO POR ID
                prestamo = controladorPrestamos.BuscarPrestamos(codigoEjemplar)[0];
            }
        }
    }
}