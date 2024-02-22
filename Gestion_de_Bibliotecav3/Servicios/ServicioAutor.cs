using Gestion_de_Bibliotecav3.DAL;
using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Gestion_de_Bibliotecav3.Dominio;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Servicios
{
    /// <summary>
    /// Clase de servicio para la gestión de autores
    /// </summary>
    internal class ServicioAutor
    {
        private RepositorioAutores repositorioAutor;

        /// <summary>
        /// Obtiene un autor por su ID
        /// </summary>
        /// <param name="id">ID del autor</param>
        /// <returns>El autor encontrado</returns>
        public Autor Get(int id)
        {
            return repositorioAutor.Get(id);
        }

        /// <summary>
        /// Obtiene todos los autores
        /// </summary>
        /// <returns>Lista de todos los autores</returns>
        public List<Autor> GetAll()
        {
            return (List<Autor>)repositorioAutor.GetAll();
        }

        /// <summary>
        /// Agrega un nuevo autor
        /// </summary>
        /// <param name="autor">El autor a agregar</param>
        public void Agregar(Autor autor)
        {
            if (autor.ID != null && !repositorioAutor.Existe(autor.ID))
            {
                repositorioAutor.Agregar(autor);
            }

            throw new SystemException();
        }

        /// <summary>
        /// Actualiza un autor existente
        /// </summary>
        /// <param name="autor">El autor actualizado</param>
        public void Actualizar(Autor autor)
        {
            if (autor.ID != null && repositorioAutor.Existe(autor.ID))
            {
                repositorioAutor.Actualizar(autor.ID, autor);
            }

            throw new SystemException(); 
        }

        /// <summary>
        /// Elimina un autor
        /// </summary>
        /// <param name="autor">El autor a eliminar</param>
        public void Eliminar(Autor autor)
        {
            if (autor.ID != null && repositorioAutor.Existe(autor.ID))
            {
                repositorioAutor.Eliminar(autor.ID, autor);
            }

            throw new SystemException(); 
        }
    }
}
