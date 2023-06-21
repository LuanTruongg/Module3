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

        public IActionResult Index()
        {
            var userViewModel = new UserViewModel()
            {
                Id = 1,
                Name = "Test",
            };
            return View(userViewModel);
        }
        public IActionResult PartialViewData()
        {
            var article = new Article()
            {
                Id = 1,
                Title = "Article Title",
                AuthorName = "Naul",
                PublicationDate = DateTime.Now,
                Sections = new List<ArticleSection>()
                {
                    new ArticleSection() {Id = 1, Title = "Title 1", Content = "Content 1"},
                    new ArticleSection() {Id = 2, Title = "Title 2", Content = "Content 3"},
                    new ArticleSection() {Id = 3, Title = "Title 3", Content = "Content 3"},
                }
            };
            return View(article);
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