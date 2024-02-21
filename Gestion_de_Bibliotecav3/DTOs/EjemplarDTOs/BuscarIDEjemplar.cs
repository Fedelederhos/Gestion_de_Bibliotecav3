using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs
{
    internal class BuscarIDEjemplar
    {
        public int id { get; set; }
        public string isbn { get; set; }
        public string nombre { get; set; }
        public string añoPublicacion { get; set; }  
        public string codigo { get; set; }
        public string fechaAlta { get; set; }
        public string fechaBaja { get; set; }
        public string disponibilidad { get; set; }

    }
}
