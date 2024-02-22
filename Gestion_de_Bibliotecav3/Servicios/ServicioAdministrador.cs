using Gestion_de_Bibliotecav3.Context;
using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.AdministradorDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Servicios
{
    public class ServicioAdministrador
    {
        protected Context.Context iContexto;

        public AdministradorDTO IniciarSesion(string usuario, string contrasenia)
        {
            AdministradorDTO administradorDTO = new AdministradorDTO();

            Func<Administrador, bool>[] conditions =
            {
                u => u.Usuario == usuario,
                u => u.Contrasenia == contrasenia
            };

            var user = iContexto.UnitOfWork.RepositorioAdministrador.ObtenerDonde(conditions).SingleOrDefault();

            if (user != null)
            {
                //iContexto.User = usuario;
                administradorDTO.usuario = usuario;
                administradorDTO.contrasenia = contrasenia;
                return administradorDTO;
            }

            return administradorDTO;
        }
    }
}
