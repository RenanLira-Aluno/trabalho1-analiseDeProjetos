using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace analise_de_projetos.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public int NoOfCopies { get; set; }
        public virtual ICollection<Book> Books { get; set; }


    }
}