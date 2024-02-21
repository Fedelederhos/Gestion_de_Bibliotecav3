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
    /// <summary>
    /// Clase controladora de Autor
    /// </summary>
    internal class ControladorAutor
    {
        ServicioAutor servicioAutor ;

        /// <summary>
        /// Lista por autores por coincidencia
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public List<Autor> BuscarAutoresPorCoincidencia(string nombre)
        {
            return servicioAutor.BuscarAutoresPorCoincidencia(nombre);
        }
    }
}
