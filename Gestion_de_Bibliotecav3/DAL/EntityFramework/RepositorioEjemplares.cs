using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

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
                if (ejemplar.Libro.ISBN == isbn)
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
                if (ejemplar.Libro.Nombre.Contains(nombre))
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

    }
}
