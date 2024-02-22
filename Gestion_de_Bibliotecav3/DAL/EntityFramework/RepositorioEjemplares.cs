using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework
{
    /// <summary>
    /// Clase que implementa la interfaz IRepositorioEjemplares y proporciona métodos para acceder y manipular Ejemplares en la base de datos mediante Entity Framework.
    /// </summary>
    public class RepositorioEjemplares : Repository<Dominio.Ejemplar, AdministradorPrestamosDBContext>, IRepositorioEjemplares
    {
        /// <summary>
        /// Constructor de la clase RepositorioEjemplares.
        /// </summary>
        /// <param name="pDBContext">Contexto de la base de datos.</param>
        public RepositorioEjemplares(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

        /// <summary>
        /// Busca un Ejemplar por su ISBN en la base de datos.
        /// </summary>
        /// <param name="isbn">ISBN del Ejemplar a buscar.</param>
        /// <returns>Ejemplar encontrado.</returns>
        public Ejemplar BuscarEjemplarPorISBN(string isbn)
        {
            List<Ejemplar> ejemplares = (List<Ejemplar>)GetAll();
            Ejemplar ejemplarEncotnrado = new Ejemplar();

            foreach (Ejemplar ejemplar in ejemplares)
            {
                if (ejemplar.Libro.ISBN == isbn && ejemplar.FechaBaja != null)
                {
                    ejemplarEncotnrado = ejemplar;
                }
            }

            return ejemplarEncotnrado;
        }

        /// <summary>
        /// Busca Ejemplares por su nombre en la base de datos.
        /// </summary>
        /// <param name="nombre">Nombre del Ejemplar a buscar.</param>
        /// <returns>Lista de Ejemplares encontrados.</returns>
        public List<Ejemplar> BuscarEjemplaresPorNombre(string nombre)
        {
            List<Ejemplar> ejemplares = (List<Ejemplar>)GetAll();
            List<Ejemplar> buscados = new List<Ejemplar>();

            foreach (Ejemplar ejemplar in ejemplares)
            {
                if (ejemplar.Libro.Nombre.Contains(nombre) && ejemplar.FechaBaja != null)
                {
                    buscados.Add(ejemplar);
                }
            }
            return buscados;
        }

        /// <summary>
        /// Método de búsqueda de ejemplares utilizando una API externa.
        /// </summary>
        /// <param name="isbn">ISBN del Ejemplar a buscar.</param>
        /// <returns>Ejemplar encontrado.</returns>
        public Ejemplar BuscarejemplarAPI(string isbn)
        {
            return null;
        }

        /// <summary>
        /// Busca un Ejemplar por su código en la base de datos.
        /// </summary>
        /// <param name="codigo">Código del Ejemplar a buscar.</param>
        /// <returns>Ejemplar encontrado.</returns>
        public Ejemplar BuscarPorCodigo(string codigo)
        {
            List<Ejemplar> ejemplares = (List<Ejemplar>)GetAll();
            Ejemplar buscado = new Ejemplar();

            foreach (Ejemplar ejemplar in ejemplares)
            {
                if (ejemplar.Codigo == codigo && ejemplar.FechaBaja != null)
                {
                    return buscado = ejemplar;
                }
            }
            return buscado;
        }

        /// <summary>
        /// Busca todos los ejemplares actuales en la base de datos que coinciden con la categoría proporcionada.
        /// </summary>
        /// <param name="categoria">Categoría por la cual se realiza la búsqueda.</param>
        /// <returns>Lista de ejemplares encontrados.</returns>
        public List<Ejemplar> BuscarEjemplaresPorCategoriasPorCoincidencia(Categoria categoria)
        {
            List<Ejemplar> ejemplares = (List<Ejemplar>)GetAll();
            List<Ejemplar> buscados = new List<Ejemplar>();

            foreach (Ejemplar ejemplar in ejemplares)
            {
                if (ejemplar.Libro.Categorias.Contains(categoria))
                {
                    buscados.Add(ejemplar);
                }
            }
            return buscados;
        }

        /// <summary>
        /// Busca todos los ejemplares actuales en la base de datos que coinciden con el autor proporcionado.
        /// </summary>
        /// <param name="autor">Autor por el cual se realiza la búsqueda.</param>
        /// <returns>Lista de ejemplares encontrados.</returns>
        public List<Ejemplar> BuscarEjemplaresPorAutoresPorCoincidencia(Autor autor)
        {
            List<Ejemplar> ejemplares = (List<Ejemplar>)GetAll();
            List<Ejemplar> buscados = new List<Ejemplar>();

            foreach (Ejemplar ejemplar in ejemplares)
            {
                if (ejemplar.Libro.Autores.Contains(autor))
                {
                    buscados.Add(ejemplar);
                }
            }
            return buscados;
        }
    }
}