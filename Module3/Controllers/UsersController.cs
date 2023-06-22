using Microsoft.AspNetCore.Mvc;
using Module3.Models;

namespace Module3.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            var profile = new Profile()
            {
                Name = "Rick",
                FavColor = "Blue",
                Gender = "Male",
                State = new State { Code = "OH", Name = "Ohio"}
            };
            return View(profile);
        }
    }
}
