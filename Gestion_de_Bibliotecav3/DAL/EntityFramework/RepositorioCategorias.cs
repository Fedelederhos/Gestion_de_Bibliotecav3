using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework
{
    public class RepositorioCategorias : Repository<Dominio.Categoria, AdministradorPrestamosDBContext>, IRepositorioCategorias
    {
        public RepositorioCategorias(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

        public List<Categoria> BuscarCategoriasPorCoincidencia(string nombre)
        {
            List<Categoria> cateogrias = (List<Categoria>)GetAll();
            List<Categoria> buscados = new List<Categoria>();

            foreach (Categoria categoria in cateogrias)
            {
                if (categoria.Nombre.Contains(nombre))
                {
                    buscados.Add(categoria);
                }
            }
            return buscados;
        }

        public bool ExisteCategoria(string nombre)
        {
            List<Categoria> categorias = (List<Categoria>)GetAll();
            return categorias.Exists(categoria => categoria.Nombre == nombre);
        }

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

        public List<Categoria> SaveLibro(Docs doc)
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
