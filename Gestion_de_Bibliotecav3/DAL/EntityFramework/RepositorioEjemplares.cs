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
    }
}
