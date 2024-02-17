using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Servicios
{
    public class ServicioLibro
    {
        RepositorioLibros repositorioLibro;

        public Libro BuscarLibroPorISBN(string isbn)
        {
            return repositorioLibro.BuscarPorIsbn(isbn);
        }

        public List<Libro> BuscarLibroPorNombre(string nombre)
        {
            return repositorioLibro.BuscarPorNombre(nombre);
        }

        public List<Libro> BuscarLibroPorNombreOISBN(string nombreOISBN)
        {
            List<Libro> libros = new List<Libro>();
            int number1 = 0;
            bool canConvert = int.TryParse(nombreOISBN, out number1);
            if (canConvert)
            {
                libros.Add(this.BuscarLibroPorISBN(nombreOISBN));
            }
            else
            {
                libros = this.BuscarLibroPorNombre(nombreOISBN);
            }

            if (libros.Count == 0)
            {
                // Buscar en la API
            }

            return libros;
        }

        public async Task<List<Libro>> BuscarEjemplaresPorIsbnONombre(string isbnONombre)
        {
            List<Libro> listaLibros = new List<Libro>();
            long number1 = 0;
            bool canConvert = long.TryParse(isbnONombre, out number1);
            if (canConvert)
            {
                listaLibros.Add(this.BuscarLibroPorISBN(isbnONombre));
                if (listaLibros.Count == 0)
                {
                    Libro libro = await repositorioLibro.BuscarPorIsbnAPI(isbnONombre);
                    listaLibros.Add(libro);
                }
            }
            else
            {
                listaLibros.AddRange(this.BuscarLibroPorNombre(isbnONombre));
            }

            

            return listaLibros;
        }
    }
}
