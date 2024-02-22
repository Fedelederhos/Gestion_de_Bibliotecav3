using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav3.Dominio
{
    public class Libro_Autor
    {
        public Libro Libro { get; set; }
        public Autor Autor { get; set; }

        public Libro_Autor() { }
    }
}
