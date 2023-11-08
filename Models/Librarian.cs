using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace analise_de_projetos.Models
{
    public class Librarian
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int Mobileno { get; set; }
        public virtual ICollection<Alert> Alerts { get; set; }
        public void UpdateInfo() {

        }
    }
}