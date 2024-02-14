using System;

namespace Gestion_de_Bibliotecav3.Dominio
{
    public class Editorial
    {
        private int iID;
        private string iNombre;
        private string iDireccion;
        private int iTelefono;
        public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();

        public Editorial() { }

        public Editorial(string pNombre, string pDireccion, int pTelefono)
        {
            iNombre = pNombre;
            iDireccion = pDireccion;
            iTelefono = pTelefono;
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

        public string Direccion
        {
            get { return this.iDireccion; }
            set { this.iDireccion = value; }
        }

        public int Telefono
        {
            get { return this.iTelefono; }
            set { this.iTelefono = value; }
        }
    }
}
