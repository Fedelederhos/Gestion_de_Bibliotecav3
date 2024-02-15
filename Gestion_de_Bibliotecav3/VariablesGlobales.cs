using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3
{
    public static class VariablesGlobales
    {
        public static int duracionPrestamoBase { get; set; }
        public static int puntosPorDiaDeMora { get; set; }
        public static int puntosParaDiaExtra {  get; set; }
        public static int puntosPorMalEstado { get; set; }
        public static int puntosPorCorrectaDevolucion { get; set; }
    }
}
