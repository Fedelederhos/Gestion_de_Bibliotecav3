using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DTOs.PrestamoDTOs
{
    public class PrestamoDTO
    {
        public string ID { get; set; }
        public string CodigoEjemplar { get; set; }
        public string DNIUsuario { get; set; }
        public string FechaEntrega { get; set; }
        public string FechaVencimiento { get; set; }
        public string FechaDevolucion { get; set; }
        public string Notificacion { get; set; }
    }
}
