using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication14.ViewModels
{
    public class RoleViewModels
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<IdentityRole> identityRoles { get; set; }
        public IList<string> UserRole { get; set; }

        public RoleViewModels()
        {
            identityRoles = new List<IdentityRole>();
            UserRole = new List<string>();
        }
    }
}
