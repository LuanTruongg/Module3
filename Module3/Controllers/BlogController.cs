using Microsoft.AspNetCore.Mvc;

namespace Module3.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Article()
        {
            return View();
        }
    }
}
