﻿using Gestion_de_Bibliotecav3.Controladores;
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
    public partial class GestionCategoriaForm : Form
    {
        public GestionCategoriaForm()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Categoria> lista = new List<Categoria>();
            //lista = controladorAutor.BuscarAutoresPorCoincidencia(textBusqueda.Text);
            //cargarTabla(lista);
        }

        private void cargarTabla(List<Autor> lista)
        {
            categoriasGrid.DataSource = lista;
        }
    }
}
