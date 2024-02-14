using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework
{
    public class RepositorioAutores : Repository<Dominio.Autor, AdministradorPrestamosDBContext>, IRepositorioAutores
    {
        public RepositorioAutores(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

        public List<Autor> BuscarAutoresPorCoincidencia(string nombre)
        {
            List<Autor> autores = (List<Autor>)GetAll();
            List<Autor> buscados = new List<Autor>();

            foreach (Autor autor in autores)
            {
                if (autor.Nombre.Contains(nombre))
                {
                    buscados.Add(autor);
                }
            }
            return buscados;
        }

        public bool ExisteNombre(string nombre)
        {
            List<Autor> autores = (List<Autor>)GetAll();

            return autores.Exists(autor => autor.Nombre == nombre);

        }

        public Autor BuscarAutorPorNombreEspecifico(string nombre)
        {
            List<Autor> autores = (List<Autor>)GetAll();
            Autor autorBuscado = new Autor();

            foreach (Autor autor in autores)
            {
                if (autor.Nombre == nombre)
                {
                    return autorBuscado = autor;
                }
            }

            return autorBuscado;
        }

        // Esto tiene que estar en repositorio Autor
        public List<Autor> SaveAutor(Docs doc)
        {
            List<Autor> autores = new List<Autor>();

            if (doc != null)
            {
                foreach (string autor_name in doc.AuthorName)
                {
                    if (!ExisteNombre(autor_name))
                    {
                        Autor autor = new Autor(autor_name);
                        Agregar(autor); //Debo devoler el objeto guardado, asi uso su Id
                        autor = BuscarAutorPorNombreEspecifico(autor_name); //Asi aprovecho el id generado por la BD
                        autores.Add(autor);
                    }
                    else
                    {
                        Autor autor = BuscarAutorPorNombreEspecifico(autor_name);
                        autores.Add(autor);
                    }
                }
            }

            return autores;
        }

    }
}
