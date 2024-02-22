using Gestion_de_Bibliotecav3.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav3.Dominio
{
    public class Administrador
    {
        private string iUsuario;
        private string iContrasenia;

        public Administrador() { }

        public Administrador(string iUsuario, string iContrasenia)
        {
            iUsuario = iUsuario;
            iContrasenia = iContrasenia;
        }

        public string Usuario
        {
            get { return this.iUsuario; }

            set {  this.iUsuario = value; }
        }

        public string Contrasenia
        {
            get { return this.iContrasenia; }
            set { this.iContrasenia = value;}
        }
    }
}
