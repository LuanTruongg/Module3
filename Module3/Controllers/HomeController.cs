using Microsoft.AspNetCore.Mvc;
using Module3.DI;
using Module3.Models;
using System.Diagnostics;

namespace Module3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IToDoItemRepository _toDoItemRepository;

        public HomeController(ILogger<HomeController> logger, IToDoItemRepository toDoItemRepository)
        {
            _toDoItemRepository = toDoItemRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Count"] = _toDoItemRepository.Count();
            ViewData["IsDone"] = _toDoItemRepository.CountIsDone();
            ViewData["AvgIsDone"] = _toDoItemRepository.Agv();
            return View(_toDoItemRepository.List());
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