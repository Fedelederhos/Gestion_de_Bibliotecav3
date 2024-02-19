using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav3.Dominio
{
    public enum Estado
    { 
        Bueno,
        Regular,
        Arruinado
    }

    public class Ejemplar
    {
        private int iID;
        private string iCodigo;
        private DateTime iFechaAlta;
        private DateTime? iFechaBaja;
        private Boolean iDisponibilidad;
        private Estado iEstado;
        private Libro iLibro;

        public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

        public int LibroID { get; set; }

        public Ejemplar() { }

        public Ejemplar(string pCodigo, Libro pLibro)
        {
            iCodigo = pCodigo;
            iFechaAlta = DateTime.Now;
            iFechaBaja = null;
            iLibro = pLibro;
            iDisponibilidad = true;
            iEstado = Estado.Bueno;
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

        public string Codigo
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

        public Estado Estado
        {
            get { return this.iEstado; }
            set { this.iEstado = value; }
        }
    }
}
