using Microsoft.AspNetCore.Mvc;

namespace Module3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var url = Url.Action("Index", "Blog", new { Area = "Zebra" });
            return Ok($"URL: {url}");
        }
    }
}
