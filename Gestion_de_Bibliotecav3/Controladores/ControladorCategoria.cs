﻿using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Controladores
{
    internal class ControladorCategoria
    {
        ServicioCategoria servicioCategoria;

        public List<Categoria> BuscarCategoriasPorCoincidencia(string nombre)
        {
            try
            {
                return servicioCategoria.BuscarCategoriasPorCoincidencia(nombre);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
