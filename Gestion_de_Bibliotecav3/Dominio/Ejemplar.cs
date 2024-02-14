using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav3.Dominio
{
    public class Ejemplar
    {
        private int iID;
        private int iCodigo;
        private DateTime iFechaAlta;
        private DateTime? iFechaBaja;
        private Boolean iDisponibilidad;
        private Libro iLibro;
        public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

        public int LibroID { get; set; }

        public Ejemplar() { }

        public Ejemplar(int pCodigo, Libro pLibro)
        {
            iCodigo = pCodigo;
            iFechaAlta = DateTime.Now;
            iFechaBaja = null;
            iLibro = pLibro;
            iDisponibilidad = true;
        }

        public int ID
        {
            get { return this.iID; }
            set { this.iID = value; }
        }

        public Libro Libro
        {
            get { return this.iLibro; }
            set { this.iLibro = value; }
        }

        public int Codigo
        {
            get { return this.iCodigo; }
            set { this.iCodigo = value; }
        }

        public DateTime FechaAlta
        {
            get { return this.iFechaAlta; }
            set { this.iFechaAlta = value; }
        }

        public DateTime FechaBaja
        {
            get { return (DateTime)this.iFechaBaja; }
            set { this.iFechaBaja = value; }
        }

        public Boolean Disponibilidad
        {
            get { return this.iDisponibilidad; }
            set { this.iDisponibilidad = value; }
        }


    }
}
