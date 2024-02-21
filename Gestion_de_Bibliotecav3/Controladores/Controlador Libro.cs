using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.GUI;
using Gestion_de_Bibliotecav3.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Controladores
{
    /// <summary>
    /// Clase controladora de Libro
    /// </summary>
    public class Controlador_Libro
    {
        ServicioLibro servicioLibro = new ServicioLibro();
        /// <summary>
        /// Busca a los ejemplares asociados a un libro según su ISBN o Nombre
        /// </summary>
        /// <param name="isbnONombre"></param>
        /// <returns></returns>
        public Task<List<Libro>> BuscarEjemplaresPorIsbnONombre(string isbnONombre)
        {
            return servicioLibro.BuscarLibrosPorIsbnONombre(isbnONombre);
        }

        /// <summary>
        /// Busca a los libros según su isbn o nombre
        /// </summary>
        /// <param name="nombreOISBN"></param>
        /// <returns></returns>
        public List<Libro> BuscarLibroPorNombreOISBN(string nombreOISBN)
        {
            return servicioLibro.BuscarLibroPorNombreOISBN(nombreOISBN);
        }
    }
}
