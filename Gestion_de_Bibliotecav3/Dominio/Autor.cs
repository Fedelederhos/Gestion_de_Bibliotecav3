using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gestion_de_Bibliotecav3.Dominio
{
    public class Autor
    {
        [Key]
        private int iID;
        private string iNombre;
        public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();

        //public virtual ICollection<Rol> Roles { get; set; } = new List<Rol>();
        public Autor() { }

        public Autor(string pNombre)
        {
            iNombre = pNombre;
        }

        public int ID
        {
            get { return this.iID; }
            set { this.iID = value; }
        }

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }
    }
}
