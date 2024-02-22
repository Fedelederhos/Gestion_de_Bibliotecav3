using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.AdministradorDTOs;
using Gestion_de_Bibliotecav3.Context;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Controladores
{
    /// <summary>
    /// Clase controladora encargada del LogIn del Administrador
    /// </summary>
    public class ControladorLogIn
    {
        protected Context.Context iContexto;
        /// <summary>
        /// Se encarga de iniciar la sesión del administrador
        /// </summary>
        /// <param name="pUserName"></param>
        /// <param name="pPassword"></param>
        /// <returns></returns>
        public AdministradorDTO IniciarSesion(string usuario, string contrasenia)
        {
            Func<Administrador, bool>[] conditions =
            {
                u => u.Usuario == usuario,
                u => u.Contrasenia == contrasenia
            };
           var user = iContexto.UnitOfWork.RepositorioAdministrador.ObtenerDonde(conditions).SingleOrDefault();

            if (user != null)
            {
               //iContexto.User = usuario;
               AdministradorDTO administradorDTO = new AdministradorDTO();
               administradorDTO.usuario = usuario;
               administradorDTO.contrasenia = contrasenia;
               return administradorDTO;
            }

            return null;
        }
    }
}
