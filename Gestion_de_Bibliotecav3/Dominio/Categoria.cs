using System;
using System.ComponentModel.DataAnnotations;

namespace Gestion_de_Bibliotecav3.Dominio
{
    public class Categoria
    {
        [Key]
        private int iID;
        private string iNombre;
        public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();

        public Categoria() { }

        public Categoria(string pNombre)
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
