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
    internal class ControladorPrestamos
    {
        ServicioPrestamo servicioPrestamos = new ServicioPrestamo();
        ServicioEjemplar servicioEjemplar = new ServicioEjemplar();
        ServicioUsuario servicioUsuario = new ServicioUsuario();

        public List<Prestamo> BuscarPrestamos(string codigoONombre)
        {
            List<Prestamo> prestamos = new List<Prestamo>();
            int number1 = 0;
            bool canConvert = int.TryParse(codigoONombre, out number1);
            if (canConvert)
            {
                prestamos = servicioPrestamos.BuscarPorCodigoEjemplar(int.Parse(codigoONombre));
            }
            else
            {
                prestamos = servicioPrestamos.BuscarPorNombreEjemplar(codigoONombre);
            }

            return prestamos;
        }

        public void NuevoPrestamo(Ejemplar ejemplar, Usuario usuario, DateTime fechaVencimiento)
        {
            // EL prestamo se deberia armar en el servicio
            Prestamo prestamo = new Prestamo(usuario, ejemplar, fechaVencimiento);
            servicioPrestamos.Agregar(prestamo);
        }

        public List<Prestamo> ProximosAVencerse()
        {
            return servicioPrestamos.ProximosAVencerse();
        }

        public void EliminarPrestamo(Prestamo prestamo)
        {
            servicioPrestamos.Eliminar(prestamo);
        }

        public void RegistrarDevolucionPrestamo(Prestamo prestamo, Estado estado)
        {
            servicioPrestamos.RegistrarDevolucionPrestamo(prestamo, estado);
        }

        public List<Ejemplar> ejemplaresUsuario(Usuario usuario)//modificar segun lo que pida la pantalla
        {
            return servicioPrestamos.ejemplaresUsuario(usuario);
        }

        public DateTime AsignarVencimiento(int dni)
        {
            return servicioPrestamos.AsignarVencimiento(dni);
        }
    }
}
