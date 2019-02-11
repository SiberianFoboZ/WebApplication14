using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using WebApplication14.Models;
using WebApplication14.ViewModels;

namespace WebApplication14.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModels model)
        {
            if (ModelState.IsValid)
            {
                User user = new User { UserName = model.Name, DName = model.Dname, Date = model.Date, Color = model.Color, Pot = model.Pot, PhoneNumber = model.Number };
                // добавляем пользователя
                var result = await _userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    // установка куки
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModels { ReturnUrl = returnUrl });
        }

        [HttpPost]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModels model)
        {
           
               // var resulr =
                  //  await _signInManager.PasswordSignInAsync(model.Name, null, false, false);
                var user = await _userManager.FindByNameAsync(model.Name);

                if (user != null)
                {
                    await _signInManager.SignInAsync(user, true);
                   
                }
                
            
            return RedirectToAction("UserList", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
