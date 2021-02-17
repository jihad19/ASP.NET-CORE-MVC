using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionsEtudiants1.Models
{
    public class Etudiant
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prénom { get; set; }
        public string CIN { get; set; }
        public string Adresse { get; set; }

        public Etudiant() {

        }
    }
}