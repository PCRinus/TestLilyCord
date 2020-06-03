using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class PacientModel
    {
        public int id { get; set; }
        public string Email { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int CNP { get; set; }
        public string Adresa { get; set; }
        public int Telefon { get; set; }
        public int Varsta { get; set; }
        public int Greutate { get; set; }
        public string Diagnostic { get; set; }
    }
}
