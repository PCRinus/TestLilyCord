using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class DiagnosticModel
    {
        public int id { get; set; }
        public string Diagnostic { get; set; }
        public string Investigatii_efectuate { get; set; }
        public string Rezultat_investigatii { get; set; }
        public string Tratament { get; set; }
        public string Medicatie { get; set; }
        public string Email { get; set; }
    }
}
