using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication14.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication14.Controllers
{
   //[Authorize(Roles ="admin")]
    public class HomeController : Controller
    {
        //        [Authorize]

        UserManager<User> _userManager;
        public HomeController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
     //   [Authorize]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult UserList(string searchString)
        {
            ViewData["currentFilter"] = searchString;

            var user = from s in _userManager.Users
                       select s;

            if (!string.IsNullOrEmpty(searchString))
            {
                user = user.Where(s => s.Pot.Contains(searchString)
                || s.Color.Contains(searchString));
            }
            return View(_userManager.Users.ToList());
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
