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
            try
            {
                

            }
            catch (Exception ex)
            {
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                Console.WriteLine(ex.Message);
                return null;
            }


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigoODNI"></param>
        /// <returns></returns>
        public List<Prestamo> BuscarPrestamosPorCodigoODNI(string codigoODNI)
        {
            try
            {
                return servicioPrestamo.BuscarPrestamosPorCodigoODNI(codigoODNI);

            }
            catch (Exception ex)
            {
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ejemplar"></param>
        /// <param name="usuario"></param>
        /// <param name="fechaVencimiento"></param>
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
                PopUpForm popup = new PopUpForm("Error en los parametros");
                popup.ShowDialog();
            }
            catch (Exception ex)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Prestamo> ProximosPrestamosAVencer()
        {
            try
            {
                return servicioPrestamo.ProximosPrestamosAVencer(DateTime.Today);

            }
            catch (Exception ex)
            {
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="prestamo"></param>
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
                PopUpForm popup = new PopUpForm("Error en los parametros");
                popup.ShowDialog();
            }
            catch (Exception ex)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                Console.WriteLine(ex.Message);

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="estado"></param>
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
                PopUpForm popup = new PopUpForm("Error en los parametros");
                popup.ShowDialog();
            }
            catch (Exception ex)
            {
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
                Console.WriteLine(ex.Message);

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public List<Ejemplar> ejemplaresUsuario(Usuario usuario)//modificar segun lo que pida la pantalla
        {
            try
            {
                return servicioPrestamo.ejemplaresUsuario(usuario);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
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
                PopUpForm popup = new PopUpForm("Error en los parametros");
                popup.ShowDialog();
                return null;
            }
            catch (Exception ex)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();

                return null;
            }
        }
    }
}
