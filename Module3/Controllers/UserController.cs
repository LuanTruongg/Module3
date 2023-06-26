using Microsoft.AspNetCore.Mvc;

namespace Module3.Application.User.Controllers
{
    [NamespaceRoutingConvention("Module3.Application")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
