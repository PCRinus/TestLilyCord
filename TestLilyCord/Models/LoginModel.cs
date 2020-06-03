using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace TestLilyCord.Models
{
    public class LoginModel
    {
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email-ul trebuie sa fie completat")]
        public string Email { get; set; }

        [Display(Name = "Parola")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Parola trebuie sa fie completata")]
        public string Parola { get; set; }
    }
}