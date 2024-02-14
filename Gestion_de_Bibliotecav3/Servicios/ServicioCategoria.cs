using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Servicios
{
    internal class ServicioCategoria
    {
        private RepositorioCategorias repositorioCategoria;

        public Categoria Get(int id)
        {
            return repositorioCategoria.Get(id);
        }

        public List<Categoria> GetAll()
        {
            return (List<Categoria>)repositorioCategoria.GetAll();
        }

        public void Agregar(Categoria categoria)
        {
            if (categoria.ID != null && !repositorioCategoria.Existe(categoria.ID))
            {
                repositorioCategoria.Agregar(categoria);
            }

            throw new SystemException();
        }

        public void Actualizar(Categoria categoria)
        {
            if (categoria.ID != null && repositorioCategoria.Existe(categoria.ID))
            {
                repositorioCategoria.Actualizar(categoria.ID, categoria);
            }

            throw new SystemException();
        }

        public void Eliminar(Categoria categoria)
        {
            if (categoria.ID != null && repositorioCategoria.Existe(categoria.ID))
            {
                repositorioCategoria.Eliminar(categoria.ID, categoria);
            }

            throw new SystemException();
        }

        public List<Categoria> BuscarCategoriasPorCoincidencia(string nombre)
        {
            return repositorioCategoria.BuscarCategoriasPorCoincidencia(nombre);
        }
    }
}
