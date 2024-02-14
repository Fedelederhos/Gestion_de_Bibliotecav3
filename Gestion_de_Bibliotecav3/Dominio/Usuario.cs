using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav3.Dominio
{
    public class Usuario
    {
        private int iID;
        private int iDNI;
        private string iNombre;
        private bool iBaja;
        private int iScore;
        private string iDireccion;
        private int iTelefono;
        private string iEmail;
        private int iLibrosPrestados;

        public virtual ICollection<Prestamo> Prestamo { get; set; } = new List<Prestamo>();

        public Usuario() { }

        public Usuario(int pDNI, string pNombre, string pDireccion, int pTelefono, string pEmail)
        {
            iDNI = pDNI;
            iNombre = pNombre;
            iBaja = false;
            iScore = 0;
            iDireccion = pDireccion;
            iTelefono = pTelefono;
            iEmail = pEmail;
            iLibrosPrestados = 0;
        }

        public int ID
        {
            get { return this.iID; }
            set { this.iID = value; }
        }

        public int DNI
        {
            get { return this.iDNI; }
            set { this.iDNI = value; }
        }

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }
        public bool Baja
        {
            get { return this.iBaja; }
            set { this.iBaja = value; }
        }

        public int Score
        {
            get { return this.iScore; }
            set { this.iScore = value; }
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

        public string Email
        {
            get { return this.iEmail; }
            set { this.iEmail = value; }
        }

        public int LibrosPrestados
        {
            get { return this.iLibrosPrestados; }
            set { this.iLibrosPrestados = value; }
        }
    }
}
