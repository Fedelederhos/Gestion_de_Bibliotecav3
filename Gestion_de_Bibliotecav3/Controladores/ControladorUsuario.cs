using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.UsuarioDTOs;
using Gestion_de_Bibliotecav3.GUI;
using Gestion_de_Bibliotecav3.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Bibliotecav3.Controladores
{
    /// <summary>
    /// Controlador para la gestión de usuarios.
    /// </summary>
    public class ControladorUsuario
    {
        ServicioUsuario servicioUsuario; // Instancia del servicio de usuario para acceder a la lógica de negocio.
       
        /// <summary>
        /// Crea un nuevo usuario.
        /// </summary>
        /// <param name="usuario">Datos del usuario a crear.</param>
        public void CrearUsuario(UsuarioDTO usuario)
        {
            servicioUsuario.Agregar(usuario); // Llama al servicio para agregar un nuevo usuario.
        }

        /// <summary>
        /// Modifica un usuario existente.
        /// </summary>
        /// <param name="usuario">Datos del usuario a modificar.</param>
        public void ModificarUsuario(UsuarioDTO usuario)
        {
            servicioUsuario.Actualizar(usuario); // Llama al servicio para actualizar un usuario existente.
        }

        /// <summary>
        /// Verifica si existe un usuario con el DNI especificado.
        /// </summary>
        /// <param name="dni">DNI del usuario a verificar.</param>
        /// <returns>True si el usuario existe, false en caso contrario.</returns>
        public bool Existe(string dni)
        {
            return servicioUsuario.Existe(int.Parse(dni)); // Llama al servicio para verificar la existencia de un usuario.
        }

        /// <summary>
        /// Obtiene una lista de usuarios por su nombre o DNI.
        /// </summary>
        /// <param name="dniONombre">Nombre o DNI del usuario a buscar.</param>
        /// <returns>Lista de usuarios encontrados.</returns>
        public List<UsuarioDTO> ObtenerUsuarioPorNombreODNI(string dniONombre)
        {
            return servicioUsuario.ObtenerUsuarioPorNombreODNI(dniONombre); // Llama al servicio para obtener usuarios por nombre o DNI.
        }

        /// <summary>
        /// Obtiene todos los usuarios.
        /// </summary>
        /// <returns>Lista de todos los usuarios.</returns>
        public List<UsuarioDTO> GetAll()
        {
            return servicioUsuario.GetAll(); // Llama al servicio para obtener todos los usuarios.
        }

        /// <summary>
        /// Elimina un usuario por su DNI.
        /// </summary>
        /// <param name="dni">DNI del usuario a eliminar.</param>
        public void Eliminar(string dni)
        {
            servicioUsuario.Eliminar(int.Parse(dni)); // Llama al servicio para eliminar un usuario por su DNI.
        }
    }
}
