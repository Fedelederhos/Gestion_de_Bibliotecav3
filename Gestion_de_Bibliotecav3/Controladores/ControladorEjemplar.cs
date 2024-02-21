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
    /// Clase controladora de Ejemplar
    /// </summary>
    internal class ControladorEjemplar
    {
        ServicioEjemplar servicioEjemplar;

        /// <summary>
        /// Método que crea el DTO para enviar al controlador y crear un nuevo Ejemplar
        /// </summary>
        /// <param name="ejemplar"></param>
        /// <returns></returns>
        public Ejemplar CrearEjemplar(Ejemplar ejemplar)
        {
            servicioEjemplar.Agregar(ejemplar);
            return servicioEjemplar.BuscarEjemplarPorISBN(ejemplar.Libro.ISBN);
            //La pantalla deberia mostrar que se agregó con exito.
        }

        /// <summary>
        /// Lista a todas las categorias de los ejemplares
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public List<Categoria> BuscarCategorias(string categoria)
        {
            return servicioEjemplar.BuscarCategorias(categoria);
        }

        /// <summary>
        /// Buscar a ejemplares por código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Ejemplar BuscarPorCodigo(string codigo)
        {
            return servicioEjemplar.BuscarPorCodigo(codigo);
        }

        /// <summary>
        /// Búsqueda de ejemplar por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Ejemplar BuscarEjemplarPorID(int id)
        {
            return servicioEjemplar.Get(id);
        }
        
        /// <summary>
        /// Buscar ejemplar por isbn o nombre
        /// </summary>
        /// <param name="isbnONombre"></param>
        /// <returns></returns>
        public List<Ejemplar> BuscarEjemplaresPorIsbnONombre(string isbnONombre)
        {
            List<Ejemplar> listaEjemplares = new List<Ejemplar>();
            long number1 = 0;
            bool canConvert = long.TryParse(isbnONombre, out number1);
            if (canConvert)
            {
                listaEjemplares.Add(servicioEjemplar.BuscarEjemplarPorISBN(isbnONombre));
            }
            else
            {
                listaEjemplares.AddRange(servicioEjemplar.BuscarEjemplarPorNombre(isbnONombre));
            }
            return listaEjemplares;
        }

        /// <summary>
        /// Envia el DTO al ejemplar para modificarlo
        /// </summary>
        /// <param name="ejemplar"></param>
        public void ModificarEjemplar(Ejemplar ejemplar)// necesito un nuevo constructor de ejemplar para poder cargarle una fecha de baja
        {
            servicioEjemplar.Actualizar(ejemplar);
            // Mensaje de exito
        }

        /// <summary>
        /// Llama al controldor para eliminar el ejemplar a partir del DTO recibido
        /// </summary>
        /// <param name="ejemplar"></param>
        public void EliminarEjemplar(Ejemplar ejemplar)
        {
            servicioEjemplar.Eliminar(ejemplar);
        }    
    }
}
