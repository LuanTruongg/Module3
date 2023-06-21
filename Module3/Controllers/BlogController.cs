using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module3.Models;

namespace Module3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        [Route("")] // api/blog/
        [Route("Index")] // api/blog/index
        [HttpGet]   // GET /api/blog
        public IActionResult Index()
        {
            return Ok("Index");
        }

        [Route("GetProduct/{id}")] // api/blog/GetProduct/xyz
        [HttpGet("GetProduct/{id}")]   // GET /api/blog/GetProduct/xyz
        public IActionResult GetProduct(string id)
        {
            var blog = id;
            return Ok(blog);
        }

        [HttpGet("authors/{id:int}")] // GET /api/blog/authors/3
        public IActionResult GetAuthorId(int id)
        {
            var author = id;
            return Ok(author);
        }

        [HttpPost]  // GET /api/blog
        public IActionResult Create(BlogModel model)
        {
            //add blog
            return RedirectToAction("Index");
        }
    }
}
