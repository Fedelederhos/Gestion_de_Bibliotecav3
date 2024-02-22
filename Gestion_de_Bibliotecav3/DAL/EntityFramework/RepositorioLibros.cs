using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.LibroDTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework
{
    /// <summary>
    /// Repositorio para acceder a la información de los libros en la base de datos.
    /// </summary>
    public class RepositorioLibros : Repository<Dominio.Libro, AdministradorPrestamosDBContext>, IRepositorioLibros
    {
        public RepositorioLibros(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

        private RepositorioAutores repositorioAutor; // Repositorio de autores para la gestión de relaciones.
        private RepositorioCategorias repositorioCategoria; // Repositorio de categorías para la gestión de relaciones.
        private IOpenLibraryApiClient openLibraryApiClient; // Cliente para acceder a la API de OpenLibrary.

        // Métodos a implementar
        // Existencia de ISBN en la base de datos local.
        // Búsqueda en la API y carga de datos si no existe en la base de datos.

        /// <summary>
        /// Verifica si un libro con el ISBN especificado existe en la base de datos.
        /// </summary>
        /// <param name="isbn">Número de ISBN del libro a verificar.</param>
        /// <returns>True si el libro existe, false en caso contrario.</returns>
        public bool ExisteIsbn(string isbn)
        {
            List<Libro> libros = (List<Libro>)GetAll();
            return libros.Any(libro => libro.ISBN == isbn);
        }

        /// <summary>
        /// Verifica si un libro con el nombre especificado existe en la base de datos.
        /// </summary>
        /// <param name="nombre">Nombre del libro a verificar.</param>
        /// <returns>True si el libro existe, false en caso contrario.</returns>
        public bool ExisteNombre(string nombre)
        {
            List<Libro> libros = (List<Libro>)GetAll();
            return libros.Any(libro => libro.Nombre == nombre);
        }

        /// <summary>
        /// Busca un libro por su número de ISBN en la base de datos.
        /// </summary>
        /// <param name="isbn">Número de ISBN del libro a buscar.</param>
        /// <returns>El libro encontrado, o null si no se encuentra.</returns>
        public Libro BuscarPorIsbn(string isbn)
        {
            List<Libro> libros = (List<Libro>)GetAll();
            return libros.FirstOrDefault(libro => libro.ISBN == isbn);
        }

        /// <summary>
        /// Carga los datos de un libro utilizando la API de OpenLibrary.
        /// </summary>
        /// <param name="isbn">Número de ISBN del libro a cargar.</param>
        public async void Cargar(string isbn)
        {
            HttpResponseMessage response = await openLibraryApiClient.ObtenerLibroAsync_isbn(isbn);

            if (response != null && response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();

                RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(jsonResponse);

                if (rootObject != null)
                {
                    Docs[] docs = rootObject.docs;

                    if (docs != null)
                    {
                        foreach (var doc in docs)
                        {
                            //Metodo que crea el autor y lo guarda. Devuelve los objetos
                            List<Autor> autores = repositorioAutor.SaveAutor(doc);

                            //Metodo que crea el libro y lo guarda. Que devuelva el objeto
                            Libro libro = SaveLibro(doc, isbn);

                            //Metodo que crea la categoria y lo guarda. Que devuelva el objeto
                            List<Categoria> categorias = repositorioCategoria.SaveCategoria(doc);

                            //Metodo que asocia el libro con el autor. y tal vez el libro tambien
                            AsociarLibroAutor(libro, autores, categorias); // Agregale Categoria
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Guarda un libro en la base de datos local si no existe, y lo retorna.
        /// </summary>
        /// <param name="doc">Documento con los datos del libro obtenidos de la API.</param>
        /// <param name="isbn">Número de ISBN del libro.</param>
        /// <returns>El libro guardado o encontrado en la base de datos.</returns>
        private Libro SaveLibro(Docs doc, string isbn)
        {
            //Si no existe lo creo
            if (!ExisteIsbn(isbn))
            {
                string fechaPublicacion = (doc.FirstPublishYear).ToString();
                Libro libro = new Libro(isbn, doc.Title, fechaPublicacion);
                Agregar(libro);
                return libro;
            }
            return BuscarPorIsbn(isbn);
        }

        /// <summary>
        /// Asocia un libro con sus autores y categorías correspondientes.
        /// </summary>
        /// <param name="libro">El libro a asociar.</param>
        /// <param name="autores">Lista de autores del libro.</param>
        /// <param name="categorias">Lista de categorías del libro.</param>
        private void AsociarLibroAutor(Libro libro, List<Autor> autores, List<Categoria> categorias)
        {
            foreach (Autor autor in autores)
            {
                VerificarRelaciones(libro, autor, null);
            }

            foreach (Categoria categoria in categorias)
            {
                VerificarRelaciones(libro, null, categoria);
            }

            Actualizar(libro, autores, categorias);
        }

        /// <summary>
        /// Verifica y establece las relaciones entre un libro, un autor y una categoría.
        /// </summary>
        /// <param name="libro">El libro relacionado.</param>
        /// <param name="autor">El autor relacionado.</param>
        /// <param name="categoria">La categoría relacionada.</param>
        private void VerificarRelaciones(Libro libro, Autor autor, Categoria categoria)
        {
            // Verificar si el autor ya está asociado al libro
            if (!libro.Autores.Contains(autor))
            {
                libro.Autores.Add(autor);
            }

            // Verificar si el libro ya está asociado al autor
            if (!autor.Libros.Contains(libro))
            {
                autor.Libros.Add(libro);
            }

            // Verificar si la categoría ya está asociada al libro
            if (!libro.Categorias.Contains(categoria))
            {
                libro.Categorias.Add(categoria);
            }
        }

        /// <summary>
        /// Actualiza la información del libro, autores y categorías en la base de datos.
        /// </summary>
        /// <param name="libro">El libro a actualizar.</param>
        /// <param name="autores">Lista de autores del libro.</param>
        /// <param name="categorias">Lista de categorías del libro.</param>
        /// <returns>True si la actualización fue exitosa, false en caso contrario.</returns>
        private bool Actualizar(Libro libro, List<Autor> autores, List<Categoria> categorias)
        {

            Actualizar(libro.ID, libro);

            foreach (Autor autor in autores)
            {
                // Suponiendo que cada autor tiene un ID
                repositorioAutor.Actualizar(autor.ID, autor);
            }

            foreach (Categoria categoria in categorias)
            {
                // Suponiendo que cada categoría tiene un ID
                repositorioCategoria.Actualizar(categoria.ID, categoria);
            }
            return true;
        }

        /// <summary>
        /// Busca libros por su nombre en la base de datos.
        /// </summary>
        /// <param name="nombre">Nombre del libro a buscar.</param>
        /// <returns>Lista de libros encontrados.</returns>
        public List<Libro> BuscarPorNombre(string nombre)
        {
            List<Libro> libros = (List<Libro>)GetAll();
            List<Libro> buscados = new List<Libro>();

            foreach (Libro libro in libros)
            {
                if (libro.Nombre.Contains(nombre))
                {
                    buscados.Add(libro);
                }
            }
            return buscados;
        }

        /// <summary>
        /// Busca un libro por su número de ISBN utilizando la API de OpenLibrary.
        /// </summary>
        /// <param name="isbn">Número de ISBN del libro a buscar.</param>
        /// <returns>El libro encontrado, o un libro vacío si no se encuentra.</returns>
        public async Task<Libro> BuscarPorIsbnAPI(string isbn)
        {
            Libro libro = new Libro();

            HttpResponseMessage response = await openLibraryApiClient.ObtenerLibroAsync_isbn(isbn);

            if (response != null && response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();

                RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(jsonResponse);

                if (rootObject != null)
                {
                    Docs[] docs = rootObject.docs;

                    if (docs != null)
                    {
                        foreach (var doc in docs)
                        {
                            libro.ISBN = isbn;
                            libro.Nombre = doc.Title;
                            libro.FechaPublicacion = doc.FirstPublishYear.ToString();
                            return libro;
                        }
                    }
                }
            }
            return libro;
        }

        /// <summary>
        /// Asigna un número de ISBN a un libro basado en los datos del documento de la API.
        /// </summary>
        /// <param name="doc">Documento con los datos del libro obtenidos de la API.</param>
        /// <returns>Número de ISBN asignado.</returns>
        public string AsignarIsbn(Docs doc)
        {
            foreach (string isbn in doc.Isbn)
            {
                long number1 = 0;
                bool canConvert = long.TryParse(isbn, out number1);
                if (canConvert)
                {
                    return isbn;
                }
            }
            return "1111111"; // No debería llegar a este punto, ya que se espera que la API proporcione un ISBN válido.
        }

        /// <summary>
        /// Busca libros por su nombre utilizando la API de OpenLibrary.
        /// </summary>
        /// <param name="nombre">Nombre del libro a buscar.</param>
        /// <returns>Lista de libros encontrados.</returns>
        public async Task<List<Libro>> BuscarLibroPorNombreAPI(string nombre)
        {
            List<Libro> libros = new List<Libro>();

            HttpResponseMessage response = await openLibraryApiClient.ObtenerLibroAsync_nombre(nombre);

            if (response != null && response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();

                RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(jsonResponse);

                if (rootObject != null)
                {
                    Docs[] docs = rootObject.docs;

                    if (docs != null)
                    {
                        foreach (var doc in docs)
                        {
                            Libro libro = new Libro();
                            libro.ISBN = AsignarIsbn(doc);
                            libro.Nombre = doc.Title;
                            libro.FechaPublicacion = doc.FirstPublishYear.ToString();
                            libros.Add(libro);
                        }
                    }
                }
            }
            return libros;
        }
    }
}
