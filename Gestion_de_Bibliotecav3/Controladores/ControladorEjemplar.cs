using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs;
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
        public void CrearEjemplar(CrearEjemplarDTO ejemplar)
        {
            servicioEjemplar.Agregar(ejemplar);
        }

        /// <summary>
        /// Lista a todas las categorias de los ejemplares
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public List<BuscarEjemplarDTO> BuscarEjemplaresPorCategoriasPorCoincidencia(string categoria)
        {
            return servicioEjemplar.BuscarEjemplaresPorCategoriasPorCoincidencia(categoria);
        }

        /// <summary>
        /// Buscar a ejemplares por autor
        /// </summary>
        /// <param name="autor"></param>
        /// <returns></returns>
        public List<BuscarEjemplarDTO> BuscarEjemplaresPorAutoresPorCoincidencia(string autor)
        {
            return servicioEjemplar.BuscarEjemplaresPorAutoresPorCoincidencia(autor);
        }

        /// <summary>
        /// Buscar a ejemplares por código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public BuscarEjemplarDTO BuscarPorCodigo(string codigo)
        {
            return servicioEjemplar.BuscarPorCodigo(codigo);
        }

        /// <summary>
        /// Buscar ejemplar por ISBN o nombre
        /// </summary>
        /// <param name="isbnONombre"></param>
        /// <returns></returns>
        public List<BuscarEjemplarDTO> BuscarEjemplaresPorIsbnONombre(string isbnONombre)
        {
            return servicioEjemplar.BuscarEjemplaresPorIsbnONombre(isbnONombre);
        }

        /// <summary>
        /// Enviar el DTO al ejemplar para modificarlo
        /// </summary>
        /// <param name="ejemplar"></param>
        public void ModificarEjemplar(ModificarEjemplarDTO ejemplar)// necesito un nuevo constructor de ejemplar para poder cargarle una fecha de baja
        {
            servicioEjemplar.Actualizar(ejemplar);
            // Mensaje de éxito
        }

        /// <summary>
        /// Llama al controlador para eliminar el ejemplar a partir del DTO recibido
        /// </summary>
        /// <param name="ejemplar"></param>
        public void EliminarEjemplar(EliminarEjemplarDTO ejemplar)
        {
            servicioEjemplar.Eliminar(ejemplar);
        }
    }
}
