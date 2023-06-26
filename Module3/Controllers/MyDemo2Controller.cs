using Microsoft.AspNetCore.Mvc;

namespace Module3.Controllers
{
    public class MyDemo2Controller : Controller
    {
        [Route("MyDemo2/Index")]
        public IActionResult Index()
        {
            return Ok("Hello from index page");
        }
        [Route("MyDemo2/Articles")]
        [Route("MyDemo2/Articles/{page}")]
        public IActionResult ListArticles(int page)
        {
            return Ok("Hello from ListArticles page: " + page);
        }
    }
}
