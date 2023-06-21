using Microsoft.AspNetCore.Mvc;
using Module3.Models;
using System.Diagnostics;
using System.Net;

namespace Module3.Controllers
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
            ViewData["Welcome"] = "Welcome to Index page";
            return View();
        }

        public IActionResult StronglyTypedData()
        {
            ViewData["Welcome"] = "Welcome to Strongly Typed Data page.";
            var viewModel = new Address()
            {
                Name = "Microsoft",
                Street = "One Microsoft Way",
                City = "Redmond",
                State = "WA",
                PostalCode = "98052-6399"
            };
            return View(viewModel);
        }
        public IActionResult ViewBagg()
        {
            ViewBag.Welcome = "Welcome to View Bag page.";
            ViewBag.Address = new Address()
            {
                Name = "Microsoft",
                Street = "One Microsoft Way",
                City = "Redmond",
                State = "WA",
                PostalCode = "98052-6399"
            };
            return View();
        }

        public IActionResult IsolationCss()
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