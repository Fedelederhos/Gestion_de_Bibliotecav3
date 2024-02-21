using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DAL
{
    public interface IOpenLibraryApiClient
    {
        Task<HttpResponseMessage> ObtenerLibroAsync_isbn(string consulta);
        Task<HttpResponseMessage> ObtenerLibroAsync_nombre(string nombre);
    }

}
