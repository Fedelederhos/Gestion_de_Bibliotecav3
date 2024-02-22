using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework
{
    /// <summary>
    /// Repositorio para la gestión de categorías en la base de datos
    /// </summary>
    public class RepositorioCategorias : Repository<Dominio.Categoria, AdministradorPrestamosDBContext>, IRepositorioCategorias
    {
        public RepositorioCategorias(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

        /// <summary>
        /// Verifica si existe una categoría con el nombre especificado
        /// </summary>
        /// <param name="nombre">El nombre de la categoría</param>
        /// <returns>True si la categoría existe, False de lo contrario</returns>
        public bool ExisteCategoria(string nombre)
        {
            List<Categoria> categorias = (List<Categoria>)GetAll();
            return categorias.Exists(categoria => categoria.Nombre == nombre);
        }

        /// <summary>
        /// Busca una categoría por su nombre específico
        /// </summary>
        /// <param name="nombre">El nombre de la categoría a buscar</param>
        /// <returns>La categoría encontrada, o una categoría vacía si no se encuentra</returns>
        public Categoria BuscarCategoriaPorNombreEspecifico(string nombre)
        {
            List<Categoria> cateogrias = (List<Categoria>)GetAll();
            Categoria categoriaBuscada = new Categoria();

            foreach (Categoria categoria in cateogrias)
            {
                if (categoria.Nombre == nombre)
                {
                    return categoriaBuscada = categoria;
                }
            }

            return categoriaBuscada;
        }

        /// <summary>
        /// Guarda las categorías asociadas a un documento en la base de datos
        /// </summary>
        /// <param name="doc">El documento del cual se extraen las categorías</param>
        /// <returns>Una lista de categorías guardadas</returns>
        public List<Categoria> SaveCategoria(Docs doc)
        {
            List<Categoria> categorias = new List<Categoria>();

            if (doc != null)
            {
                foreach (string subject in doc.Subject)
                {
                    if (!ExisteCategoria(subject))
                    {
                        Categoria categoria = new Categoria(subject);
                        Agregar(categoria);
                        categoria = BuscarCategoriaPorNombreEspecifico(subject);
                        categorias.Add(categoria);
                    }
                    else
                    {
                        Categoria categoria = BuscarCategoriaPorNombreEspecifico(subject);
                        categorias.Add(categoria);
                    }
                }
            }

            return categorias;
        }
    }
}
