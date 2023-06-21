using Microsoft.AspNetCore.Mvc;
using Module3.Models;
using System.Diagnostics;

namespace Module3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            ViewData["id"] = id;
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