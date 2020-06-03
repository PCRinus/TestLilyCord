using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace TestLilyCord.Models
{
    public class PacientModel
    {
        [Display(Name = "ID Pacient")]
        public int id { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email-ul trebuie sa fie completat")]
        public string Email { get; set; }

        [Display(Name = "Nume")]
        [Required(ErrorMessage = "Numele trebuie sa fie completat")]
        public string Nume { get; set; }

        [Display(Name = "Prenume")]
        [Required(ErrorMessage = "Prenumele trebuie sa fie completat")]
        public string Prenume { get; set; }

        [Display(Name = "CNP")]
        [Required(ErrorMessage = "CNP-ul trebuie sa fie completat")]
        public int CNP { get; set; }

        [Display(Name = "Adresa")]
        [Required(ErrorMessage = "Adresa trebuie sa fie completata")]
        public string Adresa { get; set; }

        [Display(Name = "Telefon")]
        [Required(ErrorMessage = "telefonul trebuie sa fie completat")]
        public int Telefon { get; set; }

        [Display(Name = "Varsta")]
        [Required(ErrorMessage = "Varsta trebuie sa fie completat")]
        public int Varsta { get; set; }

        [Display(Name = "Inaltime")]
        [Required(ErrorMessage = "Inaltimea trebuie sa fie completat")]
        public int Inaltime { get; set; }

        [Display(Name = "Greutate")]
        [Required(ErrorMessage = "Greutatea trebuie sa fie completat")]
        public int Greutate { get; set; }

        //[Display(Name = "Diagnostic")]
        //[Required(ErrorMessage = "Diagnsoticul trebuie sa fie completat")]
        //public string Diagnostic { get; set; }
    }
}