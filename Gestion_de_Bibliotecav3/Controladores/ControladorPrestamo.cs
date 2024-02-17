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
            try
            {
                // EL prestamo se deberia armar en el servicio
                Prestamo prestamo = new Prestamo(usuario, ejemplar, fechaVencimiento);
                servicioPrestamo.Agregar(prestamo);
                //La pantalla de exito
            }
            catch (SystemException s)
            {
                //La panntalla deberia mostrar que algun parametro esta mal
            }
            catch (Exception ex)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
            }
        }

        public List<Prestamo> ProximosAVencerse()
        {
            return servicioPrestamo.ProximosAVencerse();
        }

        public void EliminarPrestamo(Prestamo prestamo)
        {
            try
            {
                servicioPrestamo.Eliminar(prestamo);
                //La pantalla de exito
            }
            catch (SystemException s)
            {
                //La panntalla deberia mostrar que algun parametro esta mal
            }
            catch (Exception ex)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
            }
        }

        public void RegistrarDevolucionPrestamo(string codigo, Estado estado)
        {
            try
            {
                servicioPrestamo.RegistrarDevolucionPrestamo(codigo, estado);
                //La pantalla de exito
            }
            catch (SystemException s)
            {
                //La panntalla deberia mostrar que algun parametro esta mal
            }
            catch (Exception ex)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
            }
        }

        public List<Ejemplar> ejemplaresUsuario(Usuario usuario)//modificar segun lo que pida la pantalla
        {
            return servicioPrestamo.ejemplaresUsuario(usuario);
        }

        public DateTime? AsignarVencimiento(int dni) // Puse DateTime? porque si pasa algun error, no devolvera ese tipo de dato
        {
            try
            {
                return servicioPrestamo.AsignarVencimiento(dni);
                //La pantalla de exito
            }
            catch (SystemException s)
            {
                //La panntalla deberia mostrar que algun parametro esta mal
                return null;
            }
            catch (Exception ex)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
                return null;
            }
        }
    }
}
