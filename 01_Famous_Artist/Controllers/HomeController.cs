using _01_Famous_Artist.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _01_Famous_Artist.Controllers
{
    public class HomeController : Controller
    {
      

        public HomeController(ILogger<HomeController> logger)
        {
          
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Opponent()
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
