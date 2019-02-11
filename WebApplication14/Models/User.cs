using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace WebApplication14.Models
{
    public class User : IdentityUser
    {
       // public int id { get; set; }
       // public string Name { get; set; }
        public string DName { get; set; }
        public string Number { get; set; }
        public string Date { get; set; }
        public string Color { get; set; }
        public string Pot { get; set; }
   

       
    }
    
    }
    /*
    public class Color
    {
        public int Id { get; set; }
        public string Colors { get; set; }

        public List<User> Users { get; set; }

        public Color()
        {
            Users = new List<User>();
        }
    }

    public class Pot
    {
        public int Id { get; set; }
        public string Pots { get; set; }

        public List<User> Users { get; set; }

        public Pot()
        {
            Users = new List<User>();
        }
    } */

