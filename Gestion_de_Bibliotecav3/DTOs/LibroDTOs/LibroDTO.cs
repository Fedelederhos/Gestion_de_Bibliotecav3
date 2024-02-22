using Gestion_de_Bibliotecav3.Dominio;
using Gestion_de_Bibliotecav3.DTOs.AutorDTOs;
using Gestion_de_Bibliotecav3.DTOs.CategoriaDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DTOs.LibroDTOs
{
    public class LibroDTO
    {
        public string ISBN { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<AutorDTO> Autores { get; set; } = new List<AutorDTO>();
        public string FechaPublicacion { get; set; }
        public virtual ICollection<CategoriaDTO> Categorias { get; set; } = new List<CategoriaDTO>();
    }
}
