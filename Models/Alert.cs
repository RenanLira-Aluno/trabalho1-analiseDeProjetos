using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace analise_de_projetos.Models
{
    public class Alert
    {
        public int Id { get; set; }
        public DateOnly IssueDate { get; set; }
        public string BookName { get; set; }
        public DateOnly ReturnDate { get; set; }
        public int Fine { get; set; }
        public Librarian Librarian { get; set; }
    }
}