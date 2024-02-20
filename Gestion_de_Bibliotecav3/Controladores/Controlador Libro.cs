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
    public class Controlador_Libro
    {
        ServicioLibro servicioLibro = new ServicioLibro();

        public Task<List<Libro>> BuscarEjemplaresPorIsbnONombre(string isbnONombre)
        {
            try
            {
                return servicioLibro.BuscarLibrosPorIsbnONombre(isbnONombre);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                return null;
            }
        }

        public List<Libro> BuscarLibroPorNombreOISBN(string nombreOISBN)
        {
            try
            {
                return servicioLibro.BuscarLibroPorNombreOISBN(nombreOISBN);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                return null;
            }
        }
    }
}
