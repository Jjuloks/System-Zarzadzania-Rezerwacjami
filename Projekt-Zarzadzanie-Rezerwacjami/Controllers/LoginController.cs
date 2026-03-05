using Microsoft.AspNetCore.Mvc;

namespace Projekt_Zarzadzanie_Rezerwacjami.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult User()
        {
            return View();
        }
    }
}
