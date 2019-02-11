using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication14.ViewModels
{
    public class LoginViewModels
    {
        [Required]
        [Display(Name ="имя")]
        public string Name { get; set; }

       


        public string ReturnUrl { get; set; }
    }
}
