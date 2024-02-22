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
using Gestion_de_Bibliotecav3.DTOs.AutorDTOs;
using Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs;
using Gestion_de_Bibliotecav3.GUI;
using Gestion_de_Bibliotecav3.Servicios;

namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    public partial class ConsultaAutorForm : Form
    { 
        ControladorEjemplar controladorEjemplar = new ControladorEjemplar();
        public ConsultaAutorForm()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<BuscarEjemplarDTO> lista = new List<BuscarEjemplarDTO>();
                //lista = controladorEjemplar.Buscar (textBusqueda.Text);
                cargarTabla(lista);

            }
            catch (NullReferenceException n)
            {
                PopUpForm popup = new PopUpForm(n.ToString());
                popup.ShowDialog();
                Console.WriteLine(n.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
            }
        }

        private void cargarTabla(List<BuscarEjemplarDTO> lista)
        {
            autorDataGrid.DataSource = lista;
        }
    }
}
