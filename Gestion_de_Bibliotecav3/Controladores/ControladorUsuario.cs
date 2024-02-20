using Gestion_de_Bibliotecav3.Dominio;
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
    internal class ControladorUsuario
    {
        ServicioUsuario servicioUsuario;
        private string mensaje = "Operación exitosa";

        public void CrearUsuario(Usuario usuario)
        {
            try
            {
                servicioUsuario.Agregar(usuario);
                PopUpForm popup = new PopUpForm(mensaje);
                popup.ShowDialog();
                //Mensaje de exito
            }
            catch (SystemException s)
            {
                //La panntalla deberia mostrar que algun parametro esta mal
                PopUpForm popup = new PopUpForm("Error en los parametros");
                popup.ShowDialog();
            }
            catch (Exception ex)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                Console.WriteLine(ex.Message);
            }
        }
        public void ModificarUsuario(Usuario usuario)
        {
            try
            {
                servicioUsuario.Actualizar(usuario);
                PopUpForm popup = new PopUpForm(mensaje);
                popup.ShowDialog();
                //Mensaje de exito
            }
            catch (SystemException s)
            {
                //La panntalla deberia mostrar que algun parametro esta mal
                PopUpForm popup = new PopUpForm("Error en los parametros");
                popup.ShowDialog();
            }
            catch (Exception ex)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                Console.WriteLine(ex.Message);
            }
        }

        public bool Existe(string dni)
        {
            try
            {
                return servicioUsuario.Existe(int.Parse(dni));
            }
            catch (Exception e) 
            {
                PopUpForm popup = new PopUpForm(e.ToString());
                popup.ShowDialog();
                Console.WriteLine(e.ToString());
                return false;
            }
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
                PopUpForm popup = new PopUpForm("Error en los parametros");
                popup.ShowDialog();
                return null;
            }
            catch (Exception e)
            {

                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
                PopUpForm popup = new PopUpForm(e.ToString());
                popup.ShowDialog();
                Console.WriteLine(e.Message);

                return null;
            }

        }

        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                return servicioUsuario.GetAll();
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.ToString());
                PopUpForm popup = new PopUpForm(e.ToString());
                popup.ShowDialog();
                return usuarios;
            }
        }

        public void Eliminar(string dni)
        {
            try
            {
                servicioUsuario.Eliminar(int.Parse(dni));
                PopUpForm popup = new PopUpForm(mensaje);
                popup.ShowDialog();
                //Mensaje de exito
            }
            catch (SystemException s)
            {
                PopUpForm popup = new PopUpForm("Error en los parametros");
                popup.ShowDialog(); 
                //La panntalla deberia mostrar que algun parametro esta mal
            }
            catch (Exception ex)
            {
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
                Console.WriteLine(ex.Message);

            }
        }
    }
}
