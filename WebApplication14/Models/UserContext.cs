using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace WebApplication14.Models
{
    public class UserContext : IdentityDbContext<User>
    {
        
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
            
            Database.EnsureCreated();
        }

       
    }

  
}
