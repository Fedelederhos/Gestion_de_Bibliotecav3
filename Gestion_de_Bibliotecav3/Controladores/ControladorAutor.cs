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
    internal class ControladorAutor
    {
        ServicioAutor servicioAutor ;

        public List<Autor> BuscarAutoresPorCoincidencia(string nombre)
        {
            try
            {
                return servicioAutor.BuscarAutoresPorCoincidencia(nombre);

            }
            catch (NullReferenceException n)
            {
                PopUpForm popup = new PopUpForm(n.ToString());
                popup.ShowDialog();
                Console.WriteLine(n.Message);
                return null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PopUpForm popup = new PopUpForm(ex.ToString());
                popup.ShowDialog();
                return null;
            }
        }
    }
}
