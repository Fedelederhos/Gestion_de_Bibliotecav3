using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav3.Dominio
{
    public class Prestamo
    {
        private int iID;
        private DateTime iFechaEntrega;
        private DateTime iFechaVencimiento;
        private DateTime? iFechaDevolucion;
        private Ejemplar iEjemplar;
        private Usuario iUsuario;

        public int EjemplarID { get; set; }
        public int UsuarioID { get; set; }
        public Notificacion Notificacion { get; set; }

        public Prestamo() { }

        public Prestamo(Usuario pUsuario, Ejemplar pEjemplar)
        {
            iFechaEntrega = DateTime.Now;
            // iFechaVencimiento = metodo calcular en base a score usuario;
            iFechaDevolucion = null;
            iEjemplar = pEjemplar;
            iUsuario = pUsuario;
        }

        public int ID
        {
            get { return this.iID; }
            set { this.iID = value; }
        }

        public DateTime FechaEntrega
        {
            get { return this.iFechaEntrega; }
            set { this.iFechaEntrega = value; }
        }

        public DateTime FechaVencimiento
        {
            get { return this.iFechaVencimiento; }
            set { this.iFechaVencimiento = value; }
        }

        public DateTime? FechaDevolucion
        {
            get { return this.iFechaDevolucion; }
            set { this.iFechaDevolucion = value; }
        }

        public Usuario Usuario
        {
            get { return this.iUsuario; }
            set { this.iUsuario = value; }
        }

        public Ejemplar Ejemplar
        {
            get { return this.iEjemplar; }
            set { this.iEjemplar = value; }
        }

    }
}
