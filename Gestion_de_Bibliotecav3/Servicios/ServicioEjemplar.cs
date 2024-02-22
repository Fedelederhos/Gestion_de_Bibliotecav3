using Gestion_de_Bibliotecav3.DAL;
using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Servicios
{
    /// <summary>
    /// Clase encargada de proporcionar servicios relacionados con los Ejemplares en la biblioteca.
    /// </summary>
    public class ServicioEjemplar
    {
        private RepositorioEjemplares repositorioEjemplar;
        private ServicioCategoria servicioCategoria;
        private ServicioDTO servicioDTO;

        /// <summary>
        /// Obtiene un Ejemplar por su ID.
        /// </summary>
        /// <param name="id">ID del Ejemplar a obtener.</param>
        /// <returns>Ejemplar encontrado.</returns>
        public Ejemplar Get(int id)
        {
            return repositorioEjemplar.Get(id);
        }

        /// <summary>
        /// Obtiene todos los Ejemplares almacenados en el sistema.
        /// </summary>
        /// <returns>Lista de todos los Ejemplares.</returns>
        public List<Ejemplar> GetAll()
        {
            return (List<Ejemplar>)repositorioEjemplar.GetAll();
        }

        /// <summary>
        /// Agrega un nuevo Ejemplar al sistema utilizando un DTO.
        /// </summary>
        /// <param name="ejemplardto">DTO que contiene la información del nuevo Ejemplar.</param>
        public void Agregar(CrearEjemplarDTO ejemplardto)
        {
            if (ejemplardto.Codigo != null && !ExisteCodigo(ejemplardto.Codigo))
            {
                Ejemplar ejemplar = new Ejemplar(ejemplardto.Codigo, ejemplardto.Libro);
                repositorioEjemplar.Agregar(ejemplar);
            }

            throw new SystemException();
        }

        /// <summary>
        /// Actualiza un Ejemplar utilizando la información contenida en un DTO de modificación.
        /// </summary>
        /// <param name="ejemplar">DTO con la información actualizada del Ejemplar.</param>
        /*
        public void Actualizar(ModificarEjemplarDTO ejemplar)
        {
            if (ejemplar.codigo != null && this.ExisteCodigo(ejemplar.codigo))
            {
                repositorioEjemplar.Actualizar(repositorioEjemplar.BuscarPorCodigo(ejemplar.codigo).ID, repositorioEjemplar.BuscarPorCodigo(ejemplar.codigo));
            }

            throw new SystemException();
        }*/

        /// <summary>
        /// Elimina un Ejemplar utilizando un DTO que contiene su código único.
        /// </summary>
        /// <param name="ejemplar">DTO que contiene el código del Ejemplar a eliminar.</param>
        public void Eliminar(EliminarEjemplarDTO ejemplar)
        {
            if (ejemplar.codigo != null && this.ExisteCodigo(ejemplar.codigo))
            {
                repositorioEjemplar.Eliminar(repositorioEjemplar.BuscarPorCodigo(ejemplar.codigo).ID, repositorioEjemplar.BuscarPorCodigo(ejemplar.codigo));
            }

            throw new SystemException();
        }

        /// <summary>
        /// Busca un Ejemplar por su ISBN.
        /// </summary>
        /// <param name="isbn">ISBN del Ejemplar a buscar.</param>
        /// <returns>Ejemplar encontrado.</returns>
        public Ejemplar BuscarEjemplarPorISBN(string isbn)
        {
            return repositorioEjemplar.BuscarEjemplarPorISBN(isbn);
        }

        /// <summary>
        /// Busca Ejemplares por su nombre.
        /// </summary>
        /// <param name="nombre">Nombre del Ejemplar a buscar.</param>
        /// <returns>Lista de Ejemplares encontrados.</returns>
        public List<Ejemplar> BuscarEjemplarPorNombre(string nombre)
        {
            return repositorioEjemplar.BuscarEjemplaresPorNombre(nombre);
        }

        /// <summary>
        /// Busca Ejemplares por su ISBN o nombre.
        /// </summary>
        /// <param name="isbnONombre">ISBN o nombre del Ejemplar a buscar.</param>
        /// <returns>Lista de Ejemplares encontrados.</returns>
        public List<BuscarEjemplarDTO> BuscarEjemplaresPorIsbnONombre(string isbnONombre)
        {
            List<BuscarEjemplarDTO> listaEjemplares = new List<BuscarEjemplarDTO>();
            long number1 = 0;
            bool canConvert = long.TryParse(isbnONombre, out number1);
            if (canConvert)
            {
                listaEjemplares.Add(servicioDTO.aDTO(this.BuscarEjemplarPorISBN(isbnONombre)));
            }
            else
            {
                listaEjemplares.AddRange(this.BuscarEjemplarPorNombre(isbnONombre).Select(ejemplar => servicioDTO.aDTO(ejemplar)).ToList());
            }
            return listaEjemplares;
        }

        /// <summary>
        /// Busca un Ejemplar por su código único.
        /// </summary>
        /// <param name="codigo">Código único del Ejemplar a buscar.</param>
        /// <returns>DTO del Ejemplar encontrado.</returns>
        public BuscarEjemplarDTO BuscarPorCodigo(string codigo)
        {
            return servicioDTO.aDTO(repositorioEjemplar.BuscarPorCodigo(codigo));
        }

        /// <summary>
        /// Verifica si un Ejemplar existe en el sistema utilizando su código único.
        /// </summary>
        /// <param name="codigo">Código único del Ejemplar a verificar.</param>
        /// <returns>True si el Ejemplar existe, False si no.</returns>
        public bool ExisteCodigo(string codigo)
        {
            return (repositorioEjemplar.BuscarPorCodigo(codigo) != null) ? true : false;
        }

        /// <summary>
        /// Busca Ejemplares por categorías y retorna una lista de DTOs correspondientes.
        /// </summary>
        /// <param name="nombre">Nombre de la categoría por la cual se realiza la búsqueda.</param>
        /// <returns>Lista de DTOs de Ejemplares encontrados.</returns>
        public List<BuscarEjemplarDTO> BuscarEjemplaresPorCategoriasPorCoincidencia(string nombre)
        {
            Categoria categoria = new Categoria(nombre);
            return repositorioEjemplar.BuscarEjemplaresPorCategoriasPorCoincidencia(categoria).Select(ejemplar => servicioDTO.aDTO(ejemplar)).ToList();
        }

        /// <summary>
        /// Busca Ejemplares por autores y retorna una lista de DTOs correspondientes.
        /// </summary>
        /// <param name="nombre">Nombre del autor por el cual se realiza la búsqueda.</param>
        /// <returns>Lista de DTOs de Ejemplares encontrados.</returns>
        public List<BuscarEjemplarDTO> BuscarEjemplaresPorAutoresPorCoincidencia(string nombre)
        {
            Autor autor = new Autor(nombre);
            return repositorioEjemplar.BuscarEjemplaresPorAutoresPorCoincidencia(autor).Select(ejemplar => servicioDTO.aDTO(ejemplar)).ToList();
        }
    }
}
