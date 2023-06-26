using Microsoft.AspNetCore.Mvc;

namespace Module3.Controllers
{
    public class UrlGenerationController : Controller
    {
        public IActionResult Index()
        {
            var url = Url.Action("Buy", "Products", new { id = 17, color = "red" });
            return Content(url!);
        }
        public IActionResult Index2()
        {
            var url = Url.Action("Buy", "Products", new { id = 17 }, protocol: Request.Scheme);
            // Returns https://localhost:5001/Products/Buy/17
            return Content(url!);
        }
    }
}
