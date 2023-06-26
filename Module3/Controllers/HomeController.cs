using Microsoft.AspNetCore.Mvc;

namespace Module3.Controllers
{
    public class HomeController : Controller
    {
        [Route("~/")]
        [Route("Home")]
        [Route("[controller]/[action]")]
        //[Route("~/Home/Index")]
        //[Route("Home/Index/{id?}")]
        public IActionResult Index()
        {
            return Ok("Hello from Index");
        }
        //[Route("Home/About")]
        //[Route("Home/About/{id?}")]
        [Route("[controller]/[action]")]
        public IActionResult About()
        {
            return Ok("Hello from About");
        }
    }
}
