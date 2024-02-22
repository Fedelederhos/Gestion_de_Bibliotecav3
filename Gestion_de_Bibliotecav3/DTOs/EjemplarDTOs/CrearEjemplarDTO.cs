using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.LibroDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs
{
    public class CrearEjemplarDTO
    {
        public string Codigo {  get; set; }
        public LibroDTO Libro {  get; set; }

    }
}
