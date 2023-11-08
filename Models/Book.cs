using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace analise_de_projetos.Models
{
    public class Book
    {
        public int Id {get; set;}
        public string AuthorName { get; set; }
        public int NoOfBooks { get; set; }
        public string BookName { get; set; }
        public Catalog Catalog { get; set; }
    }
}