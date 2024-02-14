using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Servicios
{
    public class OpenLibraryApiResponseProcessor
    {
        public class OpenLibrarySearchResponse
        {
            public List<OpenLibrarySearchDoc> Docs { get; set; }
        }

        public class OpenLibrarySearchDoc
        {
            public string Key { get; set; }
            // Agrega más propiedades según la información que desees obtener
        }

        public List<string> ProcesarBusquedaPorNombre(string respuestaApi)
        {
            try
            {
                // Deserializar la respuesta JSON en un objeto C#
                var searchResults = JsonConvert.DeserializeObject<OpenLibrarySearchResponse>(respuestaApi);

                // Obtener los identificadores de los libros encontrados
                return searchResults?.Docs?.Select(doc => doc.Key).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al procesar la respuesta de búsqueda: {ex.Message}");
                return null;
            }
        }
    }
}
