using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Controladores
{
    internal class ControladorEjemplar
    {
        ServicioEjemplar servicioEjemplar;
        //Búsqueda de Libro en API por ISBN o por nombre
        public Libro ObtenerLibroAPI(string isbnONombre)
        {
            Libro obtener = new Libro();
            long number1 = 0;
            bool canConvert = long.TryParse(isbnONombre, out number1);
            if (canConvert)
            {
                //obtener = servicioEjemplar. buscar por isbn con el string isbnONombre
            }
            else
            {
                // obtener = servicioEjemplar. buscar por nombre con el string isbnONombre
            }
            return obtener;
        }

        public void CrearEjemplar(Libro libro, string codigo)
        {
            Ejemplar ejemplar = new Ejemplar(int.Parse(codigo), libro);
            servicioEjemplar.Agregar(ejemplar);
        }

        public List<Categoria> BuscarCategorias(string categoria)
        {
            return servicioEjemplar.BuscarCategorias(categoria);
        }

        /*public List<Ejemplar> BuscarEjemplaresPorCodigo()
        {
            
        }*/

        public List<Ejemplar> BuscarEjemplaresPorIsbnONombre(string isbnONombre)
        {
            List<Ejemplar> listaEjemplares = null;
            long number1 = 0;
            bool canConvert = long.TryParse(isbnONombre, out number1);
            if (canConvert)
            {
                listaEjemplares = servicioEjemplar.buscarPorISBN(isbnONombre);
            }
            else
            {
                // obtener = servicioEjemplar. buscar por nombre con el string isbnONombre
            }
            return listaEjemplares;
        }

        public void BuscarLibrosPorIsbnONombre()
        {
            //servicioEjemplar. buscar libros
        }

        public void ModificarEjemplar(string codigo, string fechaBaja, string disponibilidad)// necesito un nuevo constructor de ejemplar para poder cargarle una fecha de baja
        {
            Ejemplar ejemplar = new Ejemplar();
            servicioEjemplar.Actualizar(ejemplar);
        }

        public void EliminarEjemplar(string codigo)
        {
            //servicioEjemplar.buscarEjemplar por codigo
            Ejemplar ejemplar = new Ejemplar();
            servicioEjemplar.Eliminar(ejemplar);
        }

        public List<Editorial> BuscarEditoriales(string nombre)
        {
            return servicioEjemplar.BuscarEditoriales(nombre);
        }
    }
}
