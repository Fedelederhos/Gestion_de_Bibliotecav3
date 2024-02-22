using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.LibroDTOs;
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
    /// Controlador para la gestión de libros
    /// </summary>
    public class Controlador_Libro
    {
        ServicioLibro servicioLibro = new ServicioLibro();

        /// <summary>
        /// Busca libros utilizando una API externa según su ISBN o nombre.
        /// </summary>
        /// <param name="isbnONombre">El ISBN o nombre del libro a buscar.</param>
        /// <returns>Una lista de libros en formato DTO.</returns>
        public Task<List<LibroDTO>> BuscarLibrosPorIsbnONombreConApi(string isbnONombre)
        {
            return servicioLibro.BuscarLibrosPorIsbnONombreConApi(isbnONombre);
        }

        /// <summary>
        /// Busca libros en la base de datos local según su ISBN o nombre.
        /// </summary>
        /// <param name="nombreOISBN">El ISBN o nombre del libro a buscar.</param>
        /// <returns>Una lista de libros en formato DTO.</returns>
        public List<LibroDTO> BuscarLibrosPorIsbnONombreConBD(string nombreOISBN)
        {
            return servicioLibro.BuscarLibrosPorIsbnONombreConBD(nombreOISBN);
        }
    }
}
