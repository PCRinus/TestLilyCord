using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace TestLilyCord.Models
{
    public class MedicModel
    {
        //vrei referinte, cauta CodeLens
        [Display(Name ="Medic ID")]
        public int MedicID { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required(ErrorMessage ="Email-ul trebuie sa fie completat")]
        public string Email { get; set; }

        [Display(Name = "Prenume")]
        [Required(ErrorMessage = "Prenumele trebuie sa fie completat")]
        public string Prenume { get; set; }

        [Display(Name = "Nume")]
        [Required(ErrorMessage = "Numele trebuie sa fie completat")]
        public string Nume { get; set; }

        //[Display(Name = "Parola")]
        //[DataType(DataType.Password)]
        //[StringLength(100, MinimumLength =8, ErrorMessage ="Parola trebuie sa aiba minim 8 caractere")]
        //[Required(ErrorMessage = "Parola trebuie sa fie completata")]
        //public string Password { get; set; }

        //[Display(Name = "Confirma parola")]
        //[DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage ="Parolele trebuie sa fie identice")]
        //public string Confirm_password { get; set; }

        [Display(Name = "Grad Profesional")]
        [Required(ErrorMessage = "Gradul Profesional trebuie sa fie completat")]
        public string Grad_profesional { get; set; }

        [Display(Name = "Telefon")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Telefonul trebuie sa fie completat")]
        public int Telefon { get; set; }

        [Display(Name = "Specializare")]
        [Required(ErrorMessage = "Specializarea trebuie sa fie completata")]
        public string Specializare { get; set; }
    }
}