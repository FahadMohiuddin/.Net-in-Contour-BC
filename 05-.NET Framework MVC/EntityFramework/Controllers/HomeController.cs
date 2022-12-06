using EntityFramework.Models;
using EntityFramework.MyDbContext;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private SchoolMS _schoolMS;

        

        public HomeController(ILogger<HomeController> logger, SchoolMS schoolMS)
        {
            _schoolMS = schoolMS;
            _logger = logger;
        }

        public IActionResult Index()
        {
            address a1 = new address() { }
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