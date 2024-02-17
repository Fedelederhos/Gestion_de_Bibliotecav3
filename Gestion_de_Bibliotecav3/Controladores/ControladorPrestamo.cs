using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_de_Bibliotecav3.Controladores
{
    internal class ControladorPrestamo
    {
        ServicioPrestamo servicioPrestamo = new ServicioPrestamo();
        ServicioEjemplar servicioEjemplar = new ServicioEjemplar();
        ServicioUsuario servicioUsuario = new ServicioUsuario();

        public Prestamo BuscarPrestamoPorID(int id)
        { 
            return servicioPrestamo.BuscarPrestamoPorID(id);
        }

        public List<Prestamo> BuscarPrestamosPorCodigoODNI(string codigoODNI)
        {
            return servicioPrestamo.BuscarPrestamosPorCodigoODNI(codigoODNI);
        }

        public void NuevoPrestamo(Ejemplar ejemplar, Usuario usuario, DateTime fechaVencimiento)
        {
            // EL prestamo se deberia armar en el servicio
            Prestamo prestamo = new Prestamo(usuario, ejemplar, fechaVencimiento);
            servicioPrestamo.Agregar(prestamo);
        }

        public List<Prestamo> ProximosAVencerse()
        {
            return servicioPrestamo.ProximosAVencerse();
        }

        public void EliminarPrestamo(Prestamo prestamo)
        {
            servicioPrestamo.Eliminar(prestamo);
        }

        public void RegistrarDevolucionPrestamo(Prestamo prestamo, Estado estado)
        {
            servicioPrestamo.RegistrarDevolucionPrestamo(prestamo, estado);
        }

        public List<Ejemplar> ejemplaresUsuario(Usuario usuario)//modificar segun lo que pida la pantalla
        {
            return servicioPrestamo.ejemplaresUsuario(usuario);
        }

        public DateTime AsignarVencimiento(int dni)
        {
            return servicioPrestamo.AsignarVencimiento(dni);
        }
    }
}
