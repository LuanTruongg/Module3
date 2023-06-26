using Microsoft.AspNetCore.Mvc;

namespace Module3.Controllers
{
    public class UrlGenerationController : Controller
    {
        [HttpGet("")]
        public IActionResult Source()
        {
            var url = Url.RouteUrl("Destination_Route");
            return View();
        }

        [HttpGet("custom/url/to/destination", Name = "Destination_Route")]
        public IActionResult Destination()
        {
            return View();
        }

        //[HttpGet("custom/url/to/destination", Name = "Destination_Route")]
        public IActionResult GetId(int id)
        {
            return View(id);
        }
    }
}
