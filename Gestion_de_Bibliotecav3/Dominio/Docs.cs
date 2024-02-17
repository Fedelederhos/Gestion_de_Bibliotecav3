using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.Dominio
{
    public class Docs
    {
        public string Title { get; set; }
        public int FirstPublishYear { get; set; }
        public List<string> AuthorName { get; set; }
        public List<string> Subject { get; set; }
        public List <string> Isbn { get; set; }
    }
}
