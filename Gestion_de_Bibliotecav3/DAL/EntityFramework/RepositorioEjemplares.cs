using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework
{
    public class RepositorioEjemplares : Repository<Dominio.Ejemplar, AdministradorPrestamosDBContext>, IRepositorioEjemplares
    {
        public RepositorioEjemplares(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

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

        public Ejemplar BuscarejemplarAPI(string isbn)
        {
            return null;
        }

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
        /// Busca todos los ejemplares actuales en la base d datos que coinciden con el parametro categoria dado
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns> Devuelve una lista de ejemplares </returns>
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
        /// Busca todos los ejemplares actuales en la base d datos que coinciden con el parametro autor dado
        /// </summary>
        /// <param name="autor"></param>
        /// <returns> Devuelve una lista de ejemplares </returns>
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
