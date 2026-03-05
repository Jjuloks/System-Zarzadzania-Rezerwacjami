using Microsoft.AspNetCore.Mvc;

using Projekt_Zarzadzanie_Rezerwacjami.Models;

namespace Projekt_Zarzadzanie_Rezerwacjami.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
       public IActionResult Logowanie(string login, string password)
        {
            if (login == "admin" && password == "admin")
            {
                return RedirectToAction("","Rezerwacje");
            }
            else if (login == "user" && password == "user")
            {
                //Tu do Usera
                return RedirectToAction("", "Rezerwacje");
            }
            else
            {
                Console.WriteLine("Nieprawidlowwe dane");
            }
            return RedirectToAction("Index");
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
