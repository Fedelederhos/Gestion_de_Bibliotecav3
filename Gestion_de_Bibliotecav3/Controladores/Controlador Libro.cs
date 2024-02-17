using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Controladores
{
    public class Controlador_Libro
    {
        ServicioLibro servicioLibro;

        public List<Libro> BuscarEjemplaresPorIsbnONombre(string isbnONombre)
        {
            return servicioLibro.BuscarEjemplaresPorIsbnONombre(isbnONombre);
        }

        public List<Libro> BuscarLibroPorNombreOISBN(string nombreOISBN)
        {
            return servicioLibro.BuscarLibroPorNombreOISBN(nombreOISBN);
        }
    }
}
