using Microsoft.AspNetCore.Mvc;

namespace Module3.Controllers
{
    public class UrlGenerationController : Controller
    {
        public IActionResult Source()
        {
            // Generates /UrlGeneration/Destination
            var url = Url.Action("Destination");
            return ControllerContext.MyDisplayRouteInfo("", $" URL = {url}");
        }

        public IActionResult Destination()
        {
            return ControllerContext.MyDisplayRouteInfo();
        }
    }
}
