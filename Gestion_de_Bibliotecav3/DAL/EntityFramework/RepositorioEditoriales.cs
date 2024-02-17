using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework
{
    public class RepositorioEditoriales : Repository<Dominio.Editorial, AdministradorPrestamosDBContext>, IRepositorioEditoriales
    {
        public RepositorioEditoriales(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

        public List<Editorial> BuscarEditorialesPorCoincidencia(string nombre)
        {
            List<Editorial> editoriales = (List<Editorial>)GetAll();
            List<Editorial> buscados = new List<Editorial>();

            foreach (Editorial editorial in editoriales)
            {
                if (editorial.Nombre.Contains(nombre))
                {
                    buscados.Add(editorial);
                }
            }
            return buscados;
        }
    }
}
