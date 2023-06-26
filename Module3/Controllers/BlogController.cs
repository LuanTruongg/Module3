using Microsoft.AspNetCore.Mvc;

namespace Module3.Controllers
{
    [Area("Zebra")]
    public class BlogController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
