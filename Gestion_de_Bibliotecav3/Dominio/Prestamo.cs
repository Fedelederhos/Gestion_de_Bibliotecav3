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
        private bool iNotificacion;
        private Ejemplar iEjemplar;
        private BusquedaUsuarioDTO iUsuario;

        public int EjemplarID { get; set; }
        public int UsuarioID { get; set; }

        public Prestamo() { }

        public Prestamo(BusquedaUsuarioDTO pUsuario, Ejemplar pEjemplar, DateTime pFechaVencimiento)
        {
            iFechaEntrega = DateTime.Now;
            iFechaVencimiento = pFechaVencimiento;
            iFechaDevolucion = null;
            iNotificacion = false;
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

        public bool Notificacion
        {
            get { return this.iNotificacion;}
            set { this.iNotificacion = value; }
        }

        public BusquedaUsuarioDTO Usuario
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
