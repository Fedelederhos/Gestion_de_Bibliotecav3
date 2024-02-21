using Gestion_de_Bibliotecav3.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DTOs.LibroDTOs
{
    internal class LibroDTO
    {
        public int ID { get; set; } //va?
        public string ISBN { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Autor> Autores { get; set; } = new List<Autor>();
        public string FechaPublicacion { get; set; }
        public virtual ICollection<Categoria> Categorias { get; set; } = new List<Categoria>();
    }
}
