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
    }
}
