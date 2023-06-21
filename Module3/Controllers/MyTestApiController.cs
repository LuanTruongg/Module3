using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Module3.Controllers
{
    public class MyApiControllerAttribute : Attribute, IRouteTemplateProvider
    {
        public string Template => "api/[controller]";
        public int? Order => 2;
        public string Name { get; set; } = string.Empty;
    }

    [MyApiController]
    [ApiController]
    public class MyTestApiController : ControllerBase
    {
        // GET /api/MyTestApi
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("MyTestApiController");
        }
    }
}
