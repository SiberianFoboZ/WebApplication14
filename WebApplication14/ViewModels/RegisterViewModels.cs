using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.Models;

namespace WebApplication14.ViewModels
{
    public class RegisterViewModels
    {
        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Фамилия")]
        public string Dname { get; set; }

        //[Required]
        [Display(Name = "Год рождения")]
        public string Date { get; set; }

        [Required]
        [Display(Name = "Телефон")]
        public string Number { get; set; }

       // [Required]
        [Display(Name = "Цвет")]
        public string Color { get; set; }

       // [Required]
        [Display(Name = "Напиток")]
        public string Pot { get; set; }

    }

    
}
