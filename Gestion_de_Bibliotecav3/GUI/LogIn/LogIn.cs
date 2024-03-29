﻿using Gestion_de_Biblioteca;
using Gestion_de_Bibliotecav3.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Bibliotecav3.GUI.LogIn
{
    public partial class LogIn : Form
    {
        public bool userSuccessfullyAuthenticated;
        public ControladorAdministrador controladorLogIn = new ControladorAdministrador();  
        public LogIn()
        {
            InitializeComponent();
            userSuccessfullyAuthenticated = false;
            labelError.Visible = false;

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void textBoxContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
             if(textBoxUsuario.Text.Length == 0 && textBoxContrasenia.Text.Length == 0)
            {
                textBoxUsuario.Focus();
                ErrorMensaje("Ingrese su usuario y contraseña por favor.");
            }
            else if (textBoxUsuario.Text.Length == 0 )
            {
                textBoxUsuario.Focus();
                ErrorMensaje("Ingrese su usuario por favor.");
            }
            else if(textBoxContrasenia.Text.Length == 0)
            {
                textBoxContrasenia.Focus();
                ErrorMensaje("Ingrese su contraseña por favor.");
            }
            else
            {
                var usuario = controladorLogIn.IniciarSesion(textBoxUsuario.Text, textBoxContrasenia.Text);
                if (usuario != null)
                {
                  //iContext.User = user; que hace esto
                 // FormMenu formMenu = new FormMenu(); que hace esto
                 MenuPrincipal menuPrincipal = new MenuPrincipal();
                 // iContext.RootForm = formMenu; que hace esto
                 // formMenu.Show();
                 menuPrincipal.ShowDialog();
                 // formMenu.FormClosed += LogOut; que hace esto
                 this.Hide();
                }
                else
                {
                    textBoxContrasenia.Clear();
                    textBoxUsuario.Clear();
                    textBoxUsuario.Focus();
                    ErrorMensaje("La contraseña o usuario ingresados es incorrecto. \n    Intente de nuevo por favor.");
                }
            }
             

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ErrorMensaje(string txt) 
        {
          labelError.Text = "      " + txt;
          labelError.Visible = true;
        }

        /// <summary>
        /// Limpia la pantalla luego de que un usuario cierra sesión.
        /// </summary>
        private void LogOut(object sender, FormClosedEventArgs e)
        {
            labelError.Visible = false;
            textBoxContrasenia.Clear();
            textBoxUsuario.Clear();
            textBoxUsuario.Focus();
            this.Show();
        }
    }
}



