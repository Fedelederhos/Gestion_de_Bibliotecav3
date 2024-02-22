using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs;
using Gestion_de_Bibliotecav3.DTOs.PrestamoDTOs;
using Gestion_de_Bibliotecav3.DTOs.UsuarioDTOs;
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
        /// <param name="id">Identificador del préstamo</param>
        /// <returns>DTO del préstamo encontrado</returns>
        public PrestamoDTO BuscarPrestamoPorID(int id)
        {
            return servicioPrestamo.BuscarPrestamoPorID(id);
        }

        /// <summary>
        /// Permite buscar un préstamo por el código del Ejemplar o el DNI del usuario
        /// </summary>
        /// <param name="codigoODNI">Código del Ejemplar o DNI del usuario</param>
        /// <returns>Lista de DTOs de préstamos encontrados</returns>
        public List<PrestamoDTO> BuscarPrestamosPorCodigoODNI(string codigoODNI)
        {
            return servicioPrestamo.BuscarPrestamosPorCodigoODNI(codigoODNI);
        }

        /// <summary>
        /// Crea un nuevo préstamo a partir de los datos recibidos
        /// </summary>
        /// <param name="ejemplar">DTO del ejemplar prestado</param>
        /// <param name="usuario">DTO del usuario que realiza el préstamo</param>
        /// <param name="fechaVencimiento">Fecha de vencimiento del préstamo</param>
        public void NuevoPrestamo(BuscarEjemplarDTO ejemplar, BuscarUsuarioDTO usuario, DateTime fechaVencimiento)
        {
            servicioPrestamo.Agregar(ejemplar, usuario, fechaVencimiento);
        }

        /// <summary>
        /// Lista los préstamos próximos a vencerse dentro de un intervalo
        /// </summary>
        /// <param name="fechaHoy">Fecha actual</param>
        /// <returns>Lista de DTOs de préstamos próximos a vencerse</returns>
        public List<PrestamoAVencerDTO> ProximosPrestamosAVencer(DateTime fechaHoy)
        {
            return servicioPrestamo.ProximosPrestamosAVencer(fechaHoy);
        }

        /// <summary>
        /// Elimina el préstamo a partir del DTO recibido
        /// </summary>
        /// <param name="prestamo">DTO del préstamo a eliminar</param>
        public void EliminarPrestamo(PrestamoDTO prestamo)
        {
            servicioPrestamo.Eliminar(prestamo);
        }

        /// <summary>
        /// Registra la devolución de un préstamo
        /// </summary>
        /// <param name="codigo">Código del préstamo</param>
        /// <param name="estado">Estado de la devolución</param>
        public void RegistrarDevolucionPrestamo(string codigo, string estado)
        {
            servicioPrestamo.RegistrarDevolucionPrestamo(codigo, estado);
        }

        /// <summary>
        /// Asigna un vencimiento al préstamo a partir del DNI del usuario
        /// </summary>
        /// <param name="dni">DNI del usuario</param>
        /// <returns>Fecha de vencimiento asignada al préstamo</returns>
        public string AsignarVencimiento(string dni)
        {
            return servicioPrestamo.AsignarVencimiento(dni);
        }

        public PrestamoDTO BuscarPrestamoActivo(string codigo)
        {
            return servicioPrestamo.BuscarPrestamoActivo(codigo);
        }
    }
}
