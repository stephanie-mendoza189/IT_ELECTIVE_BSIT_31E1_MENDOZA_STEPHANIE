using Microsoft.AspNetCore.Mvc;
using ModelBindingDemo.Models;

namespace ModelBindingDemo.Controllers
{
    public class AccountController : Controller
    {
        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            
            if (model.Username == "admin" && model.Password == "123456")
            {
                
                return RedirectToAction("Welcome");
            }

            
            ModelState.AddModelError(string.Empty, "Invalid username or password.");

            return View(model);
        }

        
        [HttpGet]
        public IActionResult Welcome()
        {
            return View();
        }
    }
}