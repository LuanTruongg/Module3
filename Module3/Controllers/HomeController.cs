using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace Module3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Edit(int id)
        {
            return "Hello from Edit with Id = " + id;
        }
        [HttpPost]
        public string Edit(int id, string s)
        {
            return "Hello from Edit POST method with Id = " + id;
        }
    }
}
