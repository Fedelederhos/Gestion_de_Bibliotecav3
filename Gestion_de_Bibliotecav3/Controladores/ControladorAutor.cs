using Gestion_de_Bibliotecav3.Dominio;
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
        ServicioAutor servicioAutor;

        public List<Autor> BuscarAutoresPorCoincidencia(string nombre)
        {
            return servicioAutor.BuscarAutoresPorCoincidencia(nombre);
        }
    }
}
