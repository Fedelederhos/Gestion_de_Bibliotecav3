using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.GUI;
using Gestion_de_Bibliotecav3.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_de_Bibliotecav3.Controladores
{
    /// <summary>
    /// Clase controladora de Préstamo
    /// </summary>
    internal class ControladorPrestamo
    {
        ServicioPrestamo servicioPrestamo = new ServicioPrestamo();
        ServicioEjemplar servicioEjemplar = new ServicioEjemplar();
        ServicioUsuario servicioUsuario = new ServicioUsuario();

        /// <summary>
        /// Permite buscar un préstamo por su ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Prestamo BuscarPrestamoPorID(int id)
        {
            return servicioPrestamo.BuscarPrestamoPorID(id);
        }

        /// <summary>
        /// Permite buscar a un prestamo según el código del Ejemplar o el DNI del usuario
        /// </summary>
        /// <param name="codigoODNI"></param>
        /// <returns></returns>
        public List<Prestamo> BuscarPrestamosPorCodigoODNI(string codigoODNI)
        {
            return servicioPrestamo.BuscarPrestamosPorCodigoODNI(codigoODNI);
        }

        /// <summary>
        /// Se crea un Nuevo Préstamo a partir del DTO recibido
        /// </summary>
        /// <param name="ejemplar"></param>
        /// <param name="usuario"></param>
        /// <param name="fechaVencimiento"></param>
        public void NuevoPrestamo(Ejemplar ejemplar, Usuario usuario, DateTime fechaVencimiento)
        {
            // EL prestamo se deberia armar en el servicio
            Prestamo prestamo = new Prestamo(usuario, ejemplar, fechaVencimiento);
            servicioPrestamo.Agregar(prestamo);
            
        }

        /// <summary>
        /// Se listan los Préstamos próximos a vencerse dentro de un intervalo
        /// </summary>
        /// <returns></returns>
        public List<Prestamo> ProximosPrestamosAVencer()
        {
            return servicioPrestamo.ProximosPrestamosAVencer(DateTime.Today);
        }

        /// <summary>
        /// Se elimina el Préstamo a partir del DTO recibido
        /// </summary>
        /// <param name="prestamo"></param>
        public void EliminarPrestamo(Prestamo prestamo)
        {
            servicioPrestamo.Eliminar(prestamo);
        }

        /// <summary>
        /// Se registra la devolución de un Préstamo
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="estado"></param>
        public void RegistrarDevolucionPrestamo(string codigo, Estado estado)
        {
            servicioPrestamo.RegistrarDevolucionPrestamo(codigo, estado);
        }

        /// <summary>
        /// Se listan los ejemplares que formaron parte de un préstamo de un Usuario en particular
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public List<Ejemplar> ejemplaresUsuario(Usuario usuario)//modificar segun lo que pida la pantalla
        {
            return servicioPrestamo.ejemplaresUsuario(usuario);
        }

        /// <summary>
        /// Se le asigna un vencimiento al préstamo a partir del score de un usuario
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public DateTime? AsignarVencimiento(int dni) // Puse DateTime? porque si pasa algun error, no devolvera ese tipo de dato
        {
            return servicioPrestamo.AsignarVencimiento(dni);
        }
    }
}
