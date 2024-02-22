using Gestion_de_Bibliotecav3.DAL.EntityFramework;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.LibroDTOs;
using Gestion_de_Bibliotecav3.DTOs.UsuarioDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Servicios
{
    /// <summary>
    /// Servicio para la gestión de usuarios.
    /// </summary>
    public class ServicioUsuario
    {
        private RepositorioUsuarios repositorioUsuarios; // Repositorio para acceder a la capa de datos de usuarios.
        private ServicioDTO servicioDTO; // Servicio DTO para manipular objetos de transferencia de datos.

        /// <summary>
        /// Obtiene un usuario por su ID.
        /// </summary>
        /// <param name="id">ID del usuario.</param>
        /// <returns>Usuario encontrado.</returns>
        public Usuario Get(int id)
        {
            return repositorioUsuarios.Get(id); // Retorna el usuario obtenido por su ID.
        }

        /// <summary>
        /// Obtiene un usuario por su DNI.
        /// </summary>
        /// <param name="dni">DNI del usuario.</param>
        /// <returns>Usuario encontrado.</returns>
        public Usuario obtenerPorDni(int dni)
        {
            return repositorioUsuarios.obtenerPorDni(dni); // Retorna el usuario obtenido por su DNI.
        }

        /// <summary>
        /// Obtiene todos los usuarios como objetos de transferencia de datos (DTO).
        /// </summary>
        /// <returns>Lista de usuarios DTO.</returns>
        public List<UsuarioDTO> GetAll()
        {
            return ((List<BuscarUsuarioDTO>)repositorioUsuarios.GetAll()).Select(usuario => servicioDTO.aDTO(usuario)).ToList();
            // Retorna todos los usuarios del repositorio convertidos a DTOs.
        }

        /// <summary>
        /// Agrega un nuevo usuario.
        /// </summary>
        /// <param name="usuariodto">Datos del usuario a agregar.</param>
        public void Agregar(UsuarioDTO usuariodto)
        {
            if (usuariodto.DNI != null && !repositorioUsuarios.ExistePorDni(usuariodto.DNI))
            {
                // Si el DNI del usuario no es nulo y no existe en el repositorio, agrega el usuario.
                Usuario usuario = new Usuario(usuariodto.DNI, usuariodto.Nombre, usuariodto.Direccion, usuariodto.Telefono, usuariodto.Email);
                repositorioUsuarios.Agregar(usuario);
            }
            throw new SystemException(); // Lanza una excepción si no se cumple la condición anterior.
        }

        /// <summary>
        /// Actualiza un usuario existente.
        /// </summary>
        /// <param name="usuariodto">Datos del usuario a actualizar.</param>
        public void Actualizar(UsuarioDTO usuariodto)
        {
            if (usuariodto.DNI != null && repositorioUsuarios.ExistePorDni(usuariodto.DNI))
            { 
                // Si el DNI del usuario no es nulo y existe en el repositorio, actualiza el usuario.
                Usuario usuario = repositorioUsuarios.obtenerPorDni(usuariodto.DNI);
                repositorioUsuarios.Actualizar(usuario.ID, usuario);
            }
            throw new SystemException(); // Lanza una excepción si no se cumple la condición anterior.
        }

        /// <summary>
        /// Elimina un usuario por su DNI.
        /// </summary>
        /// <param name="dni">DNI del usuario a eliminar.</param>
        public void Eliminar(int dni)
        {
            if (dni != null && repositorioUsuarios.ExistePorDni(dni))
            { 
                // Si el DNI del usuario no es nulo y existe en el repositorio, elimina el usuario.
                Usuario usuario = repositorioUsuarios.obtenerPorDni(dni);
                repositorioUsuarios.Eliminar(usuario.ID, usuario);
            }
            throw new SystemException(); // Lanza una excepción si no se cumple la condición anterior.
        }

        /// <summary>
        /// Verifica si existe un usuario por su DNI.
        /// </summary>
        /// <param name="dni">DNI del usuario a verificar.</param>
        /// <returns>True si el usuario existe, false en caso contrario.</returns>
        public bool Existe(int dni)
        {
            return repositorioUsuarios.Existe(dni); // Retorna true si el usuario existe en el repositorio.
        }

        /// <summary>
        /// Obtiene una lista de usuarios por su nombre.
        /// </summary>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <returns>Lista de usuarios encontrados.</returns>
        public List<BuscarUsuarioDTO> obtenerPorNombre(string nombre)
        {
            return repositorioUsuarios.obtenerPorNombre(nombre).Select(usuario => servicioDTO.aDTOBuscar(usuario)).ToList(); // Retorna una lista de usuarios encontrados por su nombre.
        }

        /// <summary>
        /// Obtiene la cantidad de días extra de préstamo para un usuario.
        /// </summary>
        /// <param name="dni">DNI del usuario.</param>
        /// <returns>Cantidad de días extra.</returns>
        /// 
        public int ObtenerDiasExtra(int dni)
        {
            Usuario usuario = repositorioUsuarios.obtenerPorDni(dni);
            return (int)Math.Floor((double)(usuario.Score / VariablesGlobales.puntosParaDiaExtra));
            // Retorna la cantidad de días extra de préstamo para el usuario.
        }

        /// <summary>
        /// Obtiene una lista de usuarios por su nombre o DNI.
        /// </summary>
        /// <param name="dniONombre">Nombre o DNI del usuario.</param>
        /// <returns>Lista de usuarios encontrados.</returns>
        public List<UsuarioDTO> ObtenerUsuarioPorNombreODNI(string dniONombre)
        {
            List<UsuarioDTO> usuarios = new List<UsuarioDTO>();
            int number1 = 0;
            bool canConvert = int.TryParse(dniONombre, out number1);
            if (canConvert)
            {
                usuarios.Add(servicioDTO.aDTO(this.obtenerPorDni(int.Parse(dniONombre))));
            }
            else
            {
                usuarios.AddRange(this.obtenerPorNombre(dniONombre).Select(usuario => servicioDTO.aDTO(usuario)).ToList());
            }
            return usuarios;
            // Retorna una lista de usuarios encontrados por nombre o DNI.
        }
    }
}
