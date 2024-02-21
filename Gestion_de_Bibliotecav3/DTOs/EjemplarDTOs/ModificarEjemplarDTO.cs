using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DTOs.EjemplarDTOs
{
    public class ModificarEjemplarDTO
    {
        public string codigo {  get; set; }
        public DateTime fechaBaja { get; set; }
        public bool disponibilidad { get; set; }

    }
}
