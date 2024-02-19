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
    internal class ServicioAutor
    {
        private RepositorioAutores repositorioAutor;

        public Autor Get(int id)
        {
            return repositorioAutor.Get(id);
        }

        public List<Autor> GetAll()
        {
            return (List<Autor>)repositorioAutor.GetAll();
        }

        public void Agregar(Autor autor)
        {
            if (autor.ID != null && !repositorioAutor.Existe(autor.ID))
            {
                repositorioAutor.Agregar(autor);
            }

            throw new SystemException();
        }

        public void Actualizar(Autor autor)
        {
            if (autor.ID != null && repositorioAutor.Existe(autor.ID))
            {
                repositorioAutor.Actualizar(autor.ID, autor);
            }

            throw new SystemException();
        }

        public void Eliminar(Autor autor)
        {
            if (autor.ID != null && repositorioAutor.Existe(autor.ID))
            {
                repositorioAutor.Eliminar(autor.ID, autor);
            }

            throw new SystemException();
        }

        public List<Autor> BuscarAutoresPorCoincidencia(string nombre)
        {
            try
            {
                return repositorioAutor.BuscarAutoresPorCoincidencia(nombre);

            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message); return new List<Autor>();
            }
        }
    }
}
