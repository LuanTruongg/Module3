using Microsoft.AspNetCore.Mvc;

namespace Module3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
