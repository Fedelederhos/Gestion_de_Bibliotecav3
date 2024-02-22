using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.AdministradorDTOs;
using Gestion_de_Bibliotecav3.Context;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_de_Bibliotecav3.Servicios;

namespace Gestion_de_Bibliotecav3.Controladores
{
    /// <summary>
    /// Clase controladora encargada del LogIn del Administrador
    /// </summary>
    public class ControladorAdministrador
    {
        ServicioAdministrador servicioAdministrador;
        public AdministradorDTO IniciarSesion(string usuario, string contrasenia)
        {
            return servicioAdministrador.IniciarSesion(usuario, contrasenia);
        }
    }
}
