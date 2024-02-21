using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.GUI;
using Gestion_de_Bibliotecav3.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Controladores
{
    internal class ControladorEjemplar
    {
        ServicioEjemplar servicioEjemplar;

        public Ejemplar CrearEjemplar(Ejemplar ejemplar)
        {
            try
            {
                servicioEjemplar.Agregar(ejemplar);
                return servicioEjemplar.BuscarEjemplarPorISBN(ejemplar.Libro.ISBN);
                //La pantalla deberia mostrar que se agregó con exito.
            }
            catch (SystemException s)
            {
                //La panntalla deberia mostrar que algun parametro esta mal
                PopUpForm popup = new PopUpForm("Error en los parametros");
                popup.ShowDialog();
                return null;
            }
            catch (Exception ex)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();

                return null;
            }

        }

        public Ejemplar BuscarPorCodigo(string codigo)
        {
            try
            {
                return servicioEjemplar.BuscarPorCodigo(codigo);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                return null;
            }
        }

        public Ejemplar BuscarEjemplarPorID(int id)
        {
            try
            {
                return servicioEjemplar.Get(id);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                return null;
            }
        }

        public List<Ejemplar> BuscarEjemplaresPorIsbnONombre(string isbnONombre)
        {
            try
            {
                List<Ejemplar> listaEjemplares = new List<Ejemplar>();
                long number1 = 0;
                bool canConvert = long.TryParse(isbnONombre, out number1);
                if (canConvert)
                {
                    listaEjemplares.Add(servicioEjemplar.BuscarEjemplarPorISBN(isbnONombre));
                }
                else
                {
                    listaEjemplares.AddRange(servicioEjemplar.BuscarEjemplarPorNombre(isbnONombre));
                }
                return listaEjemplares;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                return null;
            }

            
        }

        public void ModificarEjemplar(Ejemplar ejemplar)// necesito un nuevo constructor de ejemplar para poder cargarle una fecha de baja
        {
            try
            {
                servicioEjemplar.Actualizar(ejemplar);
                // Mensaje de exito
            }
            catch (SystemException s)
            {
                // Algun parametro esta mal (id o no existe)
                PopUpForm popup = new PopUpForm("Error en los parametros");
                popup.ShowDialog();
            }
            catch (Exception e)
            {
                // Se debe mostrar este error "e.Message.ToString()"
                PopUpForm popup = new PopUpForm(e.ToString());
                popup.ShowDialog();
                Console.WriteLine(e.Message);

            }
        }

        public void EliminarEjemplar(Ejemplar ejemplar)
        {
            try
            {
                servicioEjemplar.Eliminar(ejemplar);
                // Mensaje de exito
            }
            catch (SystemException s)
            {
                // Algun parametro esta mal (id o no existe)
                PopUpForm popup = new PopUpForm("Error en los parametros");
                popup.ShowDialog();
            }
            catch (Exception e)
            {
                // Se debe mostrar este error "e.Message.ToString()"
                PopUpForm popup = new PopUpForm(e.ToString());
                popup.ShowDialog();
                Console.WriteLine(e.Message);

            }
        }

        

        
    }
}
