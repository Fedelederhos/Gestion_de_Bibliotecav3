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
    /// 
    /// </summary>
    internal class ControladorUsuario
    {
        ServicioUsuario servicioUsuario;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        public void CrearUsuario(UsuarioDTO usuario)
        {
            servicioUsuario.Agregar(usuario);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        public void ModificarUsuario(Usuario usuario)
        {
            servicioUsuario.Actualizar(usuario);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public bool Existe(string dni)
        {
            return servicioUsuario.Existe(int.Parse(dni));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dniONombre"></param>
        /// <returns></returns>
        public List<Usuario> obtenerUsuario(string dniONombre)
        {
            List<Usuario> usuarios = new List<Usuario>();
            int number1 = 0;
            bool canConvert = int.TryParse(dniONombre, out number1);
            if (canConvert)
            {
                usuarios.Add(servicioUsuario.obtenerPorDni(int.Parse(dniONombre)));
            }
            else
            {
                usuarios.AddRange(servicioUsuario.obtenerPorNombre(dniONombre));
            }
            return usuarios;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            return servicioUsuario.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dni"></param>
        public void Eliminar(string dni)
        {
            servicioUsuario.Eliminar(int.Parse(dni));
        }
    }
}
