using Gestion_de_Bibliotecav3.DAL;
using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Servicios
{
    public class OpenLibraryApiClient : IOpenLibraryApiClient
    {

        private readonly HttpClient _httpClient;
        private const string Api = "https://openlibrary.org/search.json";
        private const string Filtro = "fields=title,first_publish_year,author_name,subject";

        public OpenLibraryApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<HttpResponseMessage> ObtenerLibroAsync_isbn(string isbn)
        {
            string apiUrl = $"{Api}?q={isbn}&{Filtro}";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            return response;
        }

        public async Task<HttpResponseMessage> ObtenerLibroAsync_nombre(string nombre)
        {
            string apiUrl = $"{Api}?q={nombre}&{Filtro}";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            return response;
        }
    }
}
