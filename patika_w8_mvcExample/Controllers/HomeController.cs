using Microsoft.AspNetCore.Mvc;
using patika_w8_mvcExample.Models;
using System.Diagnostics;

namespace patika_w8_mvcExample.Controllers
{
    public class HomeController : Controller // MVC'deki controller sýnýfý
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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
