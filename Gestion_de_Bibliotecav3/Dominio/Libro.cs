using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gestion_de_Bibliotecav3.Dominio
{
    public class Libro
    {
        [Key]
        private int iID;
        private string iISBN;
        private string iNombre;
        private string iFechaPublicacion;

        public virtual ICollection<Autor> Autores { get; set; } = new List<Autor>();
        public virtual ICollection<Categoria> Categorias { get; set; } = new List<Categoria>();
        public virtual ICollection<Ejemplar> Ejemplares { get; set; } = new List<Ejemplar>();

        public Libro() { }

        public Libro(string pISBN, string pNombre, string pFechaPublicacion)
        {
            iISBN = pISBN;
            iNombre = pNombre;
            iFechaPublicacion = pFechaPublicacion;
        }

        public int ID
        {
            get { return this.iID; }
            set { this.iID = value; }
        }

        public string ISBN
        {
            get { return this.iISBN; }
            set { this.iISBN = value; }
        }

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        public string FechaPublicacion
        {
            get { return this.iFechaPublicacion; }
            set { this.iFechaPublicacion = value; }
        }

       

    }
}
