using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class MedicModel
    {
        public int Id { get; set; }
        public int MedicId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Grad_profesional { get; set; }
        public int Telefon { get; set; }
        public string Specializare { get; set; }
    }
}
