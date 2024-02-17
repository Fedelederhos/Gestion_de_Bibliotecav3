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
            List<Libro> listaLibros = new List<Libro>();
            long number1 = 0;
            bool canConvert = long.TryParse(isbnONombre, out number1);
            if (canConvert)
            {
                listaLibros.Add(servicioLibro.BuscarLibroPorISBN(isbnONombre));
            }
            else
            {
                listaLibros.AddRange(servicioLibro.BuscarLibroPorNombre(isbnONombre));
            }
            return listaLibros;
        }

        public List<Libro> BuscarLibroPorNombreOISBN(string nombreOISBN)
        {
            return servicioLibro.BuscarLibroPorNombreOISBN(nombreOISBN);
        }
    }
}
