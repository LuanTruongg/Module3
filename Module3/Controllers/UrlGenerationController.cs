using Microsoft.AspNetCore.Mvc;

namespace Module3.Controllers
{
    public class UrlGenerationController : Controller
    {
        [HttpGet("custom")]
        public IActionResult Source()
        {
            // Generates /UrlGeneration/Destination
            var url = Url.Action("Destination");
            return Ok($" URL = {url}");
        }
        [HttpGet("custom/url/to/destination")]
        public IActionResult Destination()
        {
            return Ok("Hello");
        }
    }
}
