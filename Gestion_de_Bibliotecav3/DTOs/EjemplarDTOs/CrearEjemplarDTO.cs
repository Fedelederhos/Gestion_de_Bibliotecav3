using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs
{
    internal class CrearEjemplarDTO
    {
        public string codigo {  get; set; }
        public Libro iLibro {  get; set; }

    }
}
