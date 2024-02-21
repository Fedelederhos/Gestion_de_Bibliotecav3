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
    /// Clase controladora de categoria
    /// </summary>
    internal class ControladorCategoria
    {
        ServicioCategoria servicioCategoria;

        /// <summary>
        /// Lista por categoria por coincidencia
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public List<Categoria> BuscarCategoriasPorCoincidencia(string nombre)
        {
            return servicioCategoria.BuscarCategoriasPorCoincidencia(nombre);
        }
    }
}
