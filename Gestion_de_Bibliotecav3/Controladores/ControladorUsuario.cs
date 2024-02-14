using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Controladores
{
    internal class ControladorUsuario
    {
        ServicioUsuario servicioUsuario;
        public void CrearUsuario(string dni, string nombre, string direccion, string telefono, string email)
        {
            Usuario usuario = new Usuario(int.Parse(dni), nombre, direccion, int.Parse(telefono), email);
            servicioUsuario.Agregar(usuario);
        }
        public void ModificarUsuario(string dni, string nombre, string direccion, string telefono, string email)
        {
            Usuario usuario = new Usuario(int.Parse(dni), nombre, direccion, int.Parse(telefono), email);
            servicioUsuario.Actualizar(usuario);
        }

        public bool Existe(string dni)
        {
            return servicioUsuario.Existe(int.Parse(dni));
        }

        public Usuario obtenerUsuario(string dniONombre)
        {
            Usuario usuario = new Usuario();
            int number1 = 0;
            bool canConvert = int.TryParse(dniONombre, out number1);
            if (canConvert)
            {
                usuario = servicioUsuario.obtenerPorDni(int.Parse(dniONombre));
            }
            else
            {
                // usuario = servicioUsuario.obtenerPorNombre
            }

            return usuario;
        }

        public List<Usuario> GetAll()
        {
            return servicioUsuario.GetAll();
        }

        public void Eliminar(string dni)
        {
            servicioUsuario.Eliminar(int.Parse(dni));
        }
    }
}
