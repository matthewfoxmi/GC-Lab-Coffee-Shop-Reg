using GC_Lab_Coffee_Reg.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GC_Lab_Coffee_Reg.Controllers
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
            Coffee c = new Coffee()
            {
                FirstName = "First Name",
                LastName = "First Name",
                Email = "EmailAddress",
                Password = "Password"
            };
            return View(c);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Greeting(Coffee c)
        {            

            return View(c);
        }                

        public IActionResult Reg()
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