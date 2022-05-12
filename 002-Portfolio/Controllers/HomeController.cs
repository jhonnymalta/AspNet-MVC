using _002_Portfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _002_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var profile = new UserProfile()
            {
                Name = "Jhonatan Landes",
                Email = "contato@jotalandes.com.br",
                Telefone = "(031) 999328177"
            };
            //ViewBag.NameProfile = "Jhonatan Landes";
            return View( profile);
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