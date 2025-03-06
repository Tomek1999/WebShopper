using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebShopper.Models;

namespace WebShopper.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            ///this.configuration = configuration;
        }


        public IActionResult Register()
        {
            //if (signInManager.IsSignedIn(User))
            //{
            //    return RedirectToAction("Index", "Home");
            //}

            return View();
        }
    }
}