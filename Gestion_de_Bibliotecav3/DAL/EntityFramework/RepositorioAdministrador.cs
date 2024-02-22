using Gestion_de_Bibliotecav3.Dominio;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework
{
    public class RepositorioAdministrador : Repository<Dominio.Administrador, AdministradorPrestamosDBContext>, IRepositorioAdministrador
    {
        public RepositorioAdministrador(AdministradorPrestamosDBContext pDBContext) : base(pDBContext){ }

            /// <summary>
            /// Obtiene todas las Medias de la base de datos que cumplen con un listado de condiciones.
            /// </summary>
            /// <param name="pConditions">Listado de condiciones.</param>
            /// <returns>Enumeración de medias que cumplen con un listado de condiciones.</returns>
        public override IEnumerable<Administrador> ObtenerDonde(IEnumerable<Func<Administrador, bool>> pCondicion)
        {
            return iDBContext.Categorias.AsEnumerable().Where(usuario => pCondicion.All(condition => condition(usuario)));
           
        }
    }
    }

