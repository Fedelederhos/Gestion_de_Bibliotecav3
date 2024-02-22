using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework
{
    /// <summary>
    /// Repositorio para la gestión de autores en la base de datos
    /// </summary>
    public class RepositorioAutores : Repository<Dominio.Autor, AdministradorPrestamosDBContext>, IRepositorioAutores
    {
        public RepositorioAutores(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

        /// <summary>
        /// Verifica si existe un autor con el nombre especificado
        /// </summary>
        /// <param name="nombre">El nombre del autor</param>
        /// <returns>True si el autor existe, False de lo contrario</returns>
        public bool ExisteNombre(string nombre)
        {
            List<Autor> autores = (List<Autor>)GetAll();
            return autores.Exists(autor => autor.Nombre == nombre);
        }

        /// <summary>
        /// Busca un autor por su nombre específico
        /// </summary>
        /// <param name="nombre">El nombre del autor a buscar</param>
        /// <returns>El autor encontrado, o un autor vacío si no se encuentra</returns>
        public Autor BuscarAutorPorNombreEspecifico(string nombre)
        {
            List<Autor> autores = (List<Autor>)GetAll();
            Autor autorBuscado = new Autor();

            foreach (Autor autor in autores)
            {
                if (autor.Nombre == nombre)
                {
                    return autorBuscado = autor;
                }
            }

            return autorBuscado;
        }

        /// <summary>
        /// Guarda los autores asociados a un documento en la base de datos
        /// </summary>
        /// <param name="doc">El documento del cual se extraen los autores</param>
        /// <returns>Una lista de autores guardados</returns>
        public List<Autor> SaveAutor(Docs doc)
        {
            List<Autor> autores = new List<Autor>();

            if (doc != null)
            {
                foreach (string autor_name in doc.AuthorName)
                {
                    if (!ExisteNombre(autor_name))
                    {
                        Autor autor = new Autor(autor_name);
                        Agregar(autor); //Debo devolver el objeto guardado, así uso su Id
                        autor = BuscarAutorPorNombreEspecifico(autor_name); //Así aprovecho el id generado por la BD
                        autores.Add(autor);
                    }
                    else
                    {
                        Autor autor = BuscarAutorPorNombreEspecifico(autor_name);
                        autores.Add(autor);
                    }
                }
            }

            return autores;
        }

    }
}
