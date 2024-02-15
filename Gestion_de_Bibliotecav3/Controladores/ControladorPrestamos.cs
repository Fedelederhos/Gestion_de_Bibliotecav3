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
        ServicioPrestamos servicioPrestamos = new ServicioPrestamos();
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

        public void RegistrarDevolucionPrestamo(Prestamo prestamo)
        {
            servicioPrestamos.RegistrarDevolucionPrestamo(prestamo);
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
