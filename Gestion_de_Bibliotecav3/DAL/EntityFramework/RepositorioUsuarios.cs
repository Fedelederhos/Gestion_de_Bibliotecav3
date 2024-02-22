using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework
{
    /// <summary>
    /// Repositorio para operaciones de acceso a datos relacionadas con usuarios en la base de datos.
    /// </summary>
    public class RepositorioUsuarios : Repository<Dominio.Usuario, AdministradorPrestamosDBContext>, IRepositorioUsuarios
    {
        /// <summary>
        /// Constructor de la clase RepositorioUsuarios.
        /// </summary>
        /// <param name="pDBContext">Contexto de base de datos utilizado por el repositorio.</param>
        public RepositorioUsuarios(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

        /// <summary>
        /// Comprueba si un usuario con el DNI especificado existe en la base de datos.
        /// </summary>
        /// <param name="dni">DNI del usuario a verificar.</param>
        /// <returns>True si el usuario existe, de lo contrario False.</returns>
        public bool ExistePorDni(int dni)
        {
            List<Usuario> usuarios = (List<Usuario>)GetAll(); // Obtiene todos los usuarios de la base de datos.
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.DNI == dni) // Comprueba si el DNI del usuario coincide con el proporcionado.
                {
                    return true; // Retorna true si se encuentra un usuario con el DNI especificado.
                }
            }
            return false; // Retorna false si no se encuentra ningún usuario con el DNI especificado.
        }

        /// <summary>
        /// Obtiene un usuario por su DNI.
        /// </summary>
        /// <param name="dni">DNI del usuario a buscar.</param>
        /// <returns>El usuario encontrado por su DNI.</returns>
        public Usuario obtenerPorDni(int dni)
        {
            List<Usuario> usuarios = (List<Usuario>)GetAll(); // Obtiene todos los usuarios de la base de datos.
            Usuario usuarioBuscado = new Usuario(); // Inicializa un nuevo objeto Usuario para almacenar el usuario encontrado.

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.DNI == dni) // Comprueba si el DNI del usuario coincide con el proporcionado.
                {
                    usuarioBuscado = usuario; // Asigna el usuario encontrado al objeto usuarioBuscado.
                }
            }

            return usuarioBuscado; // Retorna el usuario encontrado por su DNI.
        }

        /// <summary>
        /// Obtiene una lista de usuarios cuyo nombre contiene la cadena especificada y que no están dados de baja.
        /// </summary>
        /// <param name="nombre">Cadena de búsqueda para el nombre del usuario.</param>
        /// <returns>Lista de usuarios cuyo nombre contiene la cadena especificada y que no están dados de baja.</returns>
        public List<Usuario> obtenerPorNombre(string nombre)
        {
            List<Usuario> usuarios = (List<Usuario>)GetAll(); // Obtiene todos los usuarios de la base de datos.
            List<Usuario> usuarioBuscado = new List<Usuario>(); // Inicializa una nueva lista para almacenar los usuarios encontrados.

            foreach (Usuario usuario in usuarios)
            {
                // Comprueba si el nombre del usuario contiene la cadena especificada y si el usuario no está dado de baja.
                if (usuario.Nombre.Contains(nombre) && !usuario.Baja)
                {
                    usuarioBuscado.Add(usuario); // Agrega el usuario a la lista de usuarios encontrados.
                }
            }

            return usuarioBuscado; // Retorna la lista de usuarios cuyo nombre contiene la cadena especificada y que no están dados de baja.
        }
    }
}
