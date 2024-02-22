using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Servicios
{
    /// <summary>
    /// Clase de servicio para la gestión de categorías
    /// </summary>
    public class ServicioCategoria
    {
        private RepositorioCategorias repositorioCategoria;

        /// <summary>
        /// Obtiene una categoría por su ID
        /// </summary>
        /// <param name="id">ID de la categoría</param>
        /// <returns>La categoría encontrada</returns>
        public Categoria Get(int id)
        {
            return repositorioCategoria.Get(id);
        }

        /// <summary>
        /// Obtiene todas las categorías
        /// </summary>
        /// <returns>Lista de todas las categorías</returns>
        public List<Categoria> GetAll()
        {
            return (List<Categoria>)repositorioCategoria.GetAll();
        }

        /// <summary>
        /// Agrega una nueva categoría
        /// </summary>
        /// <param name="categoria">La categoría a agregar</param>
        public void Agregar(Categoria categoria)
        {
            if (categoria.ID != null && !repositorioCategoria.Existe(categoria.ID))
            {
                repositorioCategoria.Agregar(categoria);
            }

            throw new SystemException();
        }

        /// <summary>
        /// Actualiza una categoría existente
        /// </summary>
        /// <param name="categoria">La categoría actualizada</param>
        public void Actualizar(Categoria categoria)
        {
            if (categoria.ID != null && repositorioCategoria.Existe(categoria.ID))
            {
                repositorioCategoria.Actualizar(categoria.ID, categoria);
            }

            throw new SystemException();
        }

        /// <summary>
        /// Elimina una categoría
        /// </summary>
        /// <param name="categoria">La categoría a eliminar</param>
        public void Eliminar(Categoria categoria)
        {
            if (categoria.ID != null && repositorioCategoria.Existe(categoria.ID))
            {
                repositorioCategoria.Eliminar(categoria.ID, categoria);
            }

            throw new SystemException();
        }
    }
}
