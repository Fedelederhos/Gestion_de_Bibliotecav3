using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Servicios
{
    internal class ServicioEditorial
    {
        private RepositorioEditoriales repositorioEditorial;

        public Editorial Get(int id)
        {
            return repositorioEditorial.Get(id);
        }

        public List<Editorial> GetAll()
        {
            return (List<Editorial>)repositorioEditorial.GetAll();
        }

        public void Agregar(Editorial editorial)
        {
            if (editorial.ID != null && !repositorioEditorial.Existe(editorial.ID))
            {
                repositorioEditorial.Agregar(editorial);
            }

            throw new SystemException();
        }

        public void Actualizar(Editorial editorial)
        {
            if (editorial.ID != null && repositorioEditorial.Existe(editorial.ID))
            {
                repositorioEditorial.Actualizar(editorial.ID, editorial);
            }

            throw new SystemException();
        }

        public void Eliminar(Editorial editorial)
        {
            if (editorial.ID != null && repositorioEditorial.Existe(editorial.ID))
            {
                repositorioEditorial.Eliminar(editorial.ID, editorial);
            }

            throw new SystemException();
        }

        public List<Editorial> BuscarEditorialesPorCoincidencia(string nombre)
        {
            return repositorioEditorial.BuscarEditorialesPorCoincidencia(nombre);
        }
    }
}
