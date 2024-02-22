using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework
{
    /// <summary>
    /// Clase que define un repositorio de préstamos utilizando Entity Framework.
    /// </summary>
    public class RepositorioPrestamos : Repository<Dominio.Prestamo, AdministradorPrestamosDBContext>, IRepositorioPrestamos
    {
        /// <summary>
        /// Constructor de la clase RepositorioPrestamos.
        /// </summary>
        /// <param name="pDBContext">Contexto de la base de datos de préstamos</param>
        public RepositorioPrestamos(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

        /// <summary>
        /// Busca préstamos en un intervalo de fechas.
        /// </summary>
        /// <param name="fechaInicio">Fecha de inicio del intervalo</param>
        /// <param name="fechaFin">Fecha de fin del intervalo</param>
        /// <returns>Lista de préstamos encontrados en el intervalo</returns>
        public List<Prestamo> buscarPorFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Prestamo> prestamos = (List<Prestamo>)GetAll();

            List<Prestamo> prestamosIntervalo = new List<Prestamo>();

            foreach (Prestamo prestamo in prestamos)
            {
                if (prestamo.FechaVencimiento >= fechaInicio && prestamo.FechaVencimiento <= fechaFin)
                {
                    prestamosIntervalo.Add(prestamo);
                }
            }

            return prestamosIntervalo;
        }

        /// <summary>
        /// Busca préstamos por el código de ejemplar.
        /// </summary>
        /// <param name="codigo">Código del ejemplar</param>
        /// <returns>Lista de préstamos encontrados</returns>
        public List<Prestamo> BuscarPrestamoPorCodigoEjemplar(string codigo)
        {
            List<Prestamo> prestamos = (List<Prestamo>)GetAll();
            List<Prestamo> prestamosCodigo = new List<Prestamo>();

            foreach (Prestamo prestamo in prestamos)
            {
                if (prestamo.Ejemplar.Codigo == codigo)
                {
                    prestamosCodigo.Add(prestamo);
                }
            }

            return prestamosCodigo;

        }

        /// <summary>
        /// Busca préstamos por el DNI del usuario.
        /// </summary>
        /// <param name="codigo">DNI del usuario</param>
        /// <returns>Lista de préstamos encontrados</returns>
        public List<Prestamo> BuscarPrestamoPorDNI(int codigo)
        {
            List<Prestamo> prestamos = (List<Prestamo>)GetAll();
            List<Prestamo> prestamosDNI = new List<Prestamo>();

            foreach (Prestamo prestamo in prestamos)
            {
                if (prestamo.Usuario.DNI == codigo)
                {
                    prestamosDNI.Add(prestamo);
                }
            }

            return prestamosDNI;

        }

        /// <summary>
        /// Busca préstamos por el nombre del ejemplar.
        /// </summary>
        /// <param name="nombre">Nombre del ejemplar</param>
        /// <returns>Lista de préstamos encontrados</returns>
        public List<Prestamo> buscarPorNombreEjemplar(string nombre)
        {
            List<Prestamo> prestamos = (List<Prestamo>)GetAll();
            List<Prestamo> prestamosNombre = new List<Prestamo>();

            foreach (Prestamo prestamo in prestamos)
            {
                if (prestamo.Ejemplar.Libro.Nombre.Contains(nombre))
                {
                    prestamosNombre.Add(prestamo);
                }
            }

            return prestamosNombre;

        }

        /// <summary>
        /// Busca los préstamos que están próximos a vencerse a partir de una fecha dada.
        /// </summary>
        /// <param name="fechaHoy">Fecha de referencia</param>
        /// <returns>Lista de préstamos próximos a vencerse</returns>
        public List<Prestamo> ProximosPrestamosAVencer(DateTime fechaHoy)
        {
            List<Prestamo> prestamos = (List<Prestamo>)GetAll();

            List<Prestamo> prestamosIntervalo = new List<Prestamo>();

            foreach (Prestamo prestamo in prestamos)
            {
                if ((prestamo.FechaVencimiento.Date - fechaHoy.Date).Days <= 2)
                {
                    prestamosIntervalo.Add(prestamo);
                }
            }

            return prestamosIntervalo;
        }
    }
}
