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
    public class ServicioEjemplar
    {
        private RepositorioEjemplares repositorioEjemplar;
        private ServicioCategoria servicioCategoria;
        private ServicioEditorial servicioEditorial;

        public Ejemplar Get(int id)
        {
            return repositorioEjemplar.Get(id);
        }

        public List<Ejemplar> GetAll()
        {
            return (List<Ejemplar>)repositorioEjemplar.GetAll();
        }

        public void Agregar(Ejemplar ejemplar)
        {
            if (ejemplar.ID != null && !repositorioEjemplar.Existe(ejemplar.ID) && !ExisteCodigo(ejemplar.Codigo))
            {
                repositorioEjemplar.Agregar(ejemplar);
            }

            throw new SystemException();
        }

        public void Actualizar(Ejemplar ejemplar)
        {
            if (ejemplar.ID != null && repositorioEjemplar.Existe(ejemplar.ID))
            {
                repositorioEjemplar.Actualizar(ejemplar.ID, ejemplar);
            }

            throw new SystemException();
        }

        public void Eliminar(Ejemplar ejemplar)
        {
            if (ejemplar.ID != null && repositorioEjemplar.Existe(ejemplar.ID))
            {
                repositorioEjemplar.Eliminar(ejemplar.ID, ejemplar);
            }

            throw new SystemException();
        }

        public Ejemplar BuscarEjemplarPorISBN(string isbn)
        {
            return repositorioEjemplar.BuscarEjemplarPorISBN(isbn);
        }

        public List<Ejemplar> BuscarEjemplarPorNombre(string nombre)
        {
            return repositorioEjemplar.BuscarEjemplaresPorNombre(nombre);
        }

        public List<Categoria> BuscarCategorias(string nombre) //Capaz deberiamos de dejar este metodo en el servicio Categoria
        {
            return servicioCategoria.BuscarCategoriasPorCoincidencia(nombre);
        }

        public List<Editorial> BuscarEditoriales(string nombre) //Capaz deberiamos de dejar este metodo en el servicio Editorial
        {
            return servicioEditorial.BuscarEditorialesPorCoincidencia(nombre);
        }

        public Ejemplar BuscarPorCodigo(string codigo)
        {
            return repositorioEjemplar.BuscarPorCodigo(codigo);
        }

        public bool ExisteCodigo(string codigo)
        {
            return (repositorioEjemplar.BuscarPorCodigo(codigo) != null) ? true : false;
        }

        public List<Ejemplar> BuscarEjemplaresPorCategoriasPorCoincidencia(string nombre)
        {
            Categoria categoria = new Categoria(nombre);
            return repositorioEjemplar.BuscarEjemplaresPorCategoriasPorCoincidencia(categoria);
        }

        public List<Ejemplar> BuscarEjemplaresPorAutoresPorCoincidencia(string nombre)
        {
            Autor autor = new Autor(nombre);
            return repositorioEjemplar.BuscarEjemplaresPorAutoresPorCoincidencia(autor);
        }
    }
}
