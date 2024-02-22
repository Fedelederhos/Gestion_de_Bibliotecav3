using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.LibroDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Servicios
{
    /// <summary>
    /// Clase que proporciona servicios relacionados con la gestión de libros.
    /// </summary>
    public class ServicioLibro
    {
        RepositorioLibros repositorioLibro; // Repositorio para acceder a los datos de los libros.
        ServicioDTO servicioDTO; // Servicio para la conversión entre entidades de dominio y DTOs.

        /// <summary>
        /// Busca un libro por su número de ISBN.
        /// </summary>
        /// <param name="isbn">Número de ISBN del libro a buscar.</param>
        /// <returns>El libro encontrado o null si no se encuentra.</returns>
        public Libro BuscarLibroPorISBN(string isbn)
        {
            return repositorioLibro.BuscarPorIsbn(isbn);
        }

        /// <summary>
        /// Busca libros por su nombre.
        /// </summary>
        /// <param name="nombre">Nombre o parte del nombre de los libros a buscar.</param>
        /// <returns>Una lista de libros que coinciden con el nombre especificado.</returns>
        public List<Libro> BuscarLibroPorNombre(string nombre)
        {
            return repositorioLibro.BuscarPorNombre(nombre);
        }

        /// <summary>
        /// Busca libros por su número de ISBN o nombre utilizando la base de datos local.
        /// </summary>
        /// <param name="nombreOISBN">Número de ISBN o nombre del libro a buscar.</param>
        /// <returns>Una lista de libros en formato DTO.</returns>
        public List<LibroDTO> BuscarLibrosPorIsbnONombreConBD(string nombreOISBN)
        {
            List<LibroDTO> librosDTO = new List<LibroDTO>();
            int number1 = 0;
            bool canConvert = int.TryParse(nombreOISBN, out number1);
            if (canConvert)
            {
                // Si el parámetro es un número, se busca por ISBN.
                librosDTO.Add(servicioDTO.aDTO(this.BuscarLibroPorISBN(nombreOISBN)));
            }
            else
            {
                // Si el parámetro no es un número, se busca por nombre.
                librosDTO = this.BuscarLibroPorNombre(nombreOISBN).Select(libro => servicioDTO.aDTO(libro)).ToList();
            }

            return librosDTO;
        }

        /// <summary>
        /// Busca libros por su número de ISBN o nombre utilizando una API externa.
        /// </summary>
        /// <param name="isbnONombre">Número de ISBN o nombre del libro a buscar.</param>
        /// <returns>Una lista de libros en formato DTO.</returns>
        public async Task<List<LibroDTO>> BuscarLibrosPorIsbnONombreConApi(string isbnONombre)
        {
            List<LibroDTO> librosDTO = new List<LibroDTO>();
            long number1 = 0;
            bool canConvert = long.TryParse(isbnONombre, out number1);
            if (canConvert)
            {
                // Si el parámetro es un número, se busca por ISBN.
                librosDTO.Add(servicioDTO.aDTO(this.BuscarLibroPorISBN(isbnONombre)));
                if (librosDTO.Count == 0)
                {
                    // Si no se encuentra en la base de datos local, se busca en la API externa.
                    Libro libro = await repositorioLibro.BuscarPorIsbnAPI(isbnONombre);
                    librosDTO.Add(servicioDTO.aDTO(libro));
                }
            }
            else
            {
                // Si el parámetro no es un número, se busca por nombre.
                string nombre = isbnONombre.Replace(" ", "+"); // Reemplazar espacios con el carácter deseado.
                librosDTO.AddRange(this.BuscarLibroPorNombre(nombre).Select(libro => servicioDTO.aDTO(libro)).ToList());
                if (librosDTO.Count == 0)
                {
                    // Si no se encuentra en la base de datos local, se busca en la API externa.
                    List<Libro> libros = await repositorioLibro.BuscarLibroPorNombreAPI(nombre);
                    librosDTO.AddRange(libros.Select(libro => servicioDTO.aDTO(libro)).ToList());
                }
            }
            return librosDTO;
        }
    }
}
