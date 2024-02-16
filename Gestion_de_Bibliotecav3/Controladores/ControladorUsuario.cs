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
        public void CrearUsuario(Usuario usuario)
        {
            try
            {
                servicioUsuario.Agregar(usuario);
                //Mensaje de exito
            }
            catch (SystemException s)
            {
                //La panntalla deberia mostrar que algun parametro esta mal
            }
            catch (Exception ex)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
            }
        }
        public void ModificarUsuario(Usuario usuario)
        {
            try
            {
                servicioUsuario.Actualizar(usuario);
                //Mensaje de exito
            }
            catch (SystemException s)
            {
                //La panntalla deberia mostrar que algun parametro esta mal
            }
            catch (Exception ex)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
            }
        }

        public bool Existe(string dni)
        {
            return servicioUsuario.Existe(int.Parse(dni));
        }

        public List<Usuario> obtenerUsuario(string dniONombre)
        {
            try
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
            catch (SystemException s)
            {
                //La panntalla deberia mostrar que algun parametro esta mal
                return null;
            }
            catch (Exception e)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
                return null;
            }

        }

        public List<Usuario> GetAll()
        {
            return servicioUsuario.GetAll();
        }

        public void Eliminar(string dni)
        {
            try
            {
                servicioUsuario.Eliminar(int.Parse(dni));
                //Mensaje de exito
            }
            catch (SystemException s)
            {
                //La panntalla deberia mostrar que algun parametro esta mal
            }
            catch (Exception ex)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
            }
        }
    }
}
