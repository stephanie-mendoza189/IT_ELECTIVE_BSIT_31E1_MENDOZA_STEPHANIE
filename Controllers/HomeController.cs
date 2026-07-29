using System.Diagnostics;
using IT_ELECTIVE_BSIT_31E1_MENDOZA_STEPHANIE.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_BSIT_31E1_MENDOZA_STEPHANIE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
