using Microsoft.AspNetCore.Mvc;

namespace Module3.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            var fullname = typeof(UsersController).FullName;
            var template =
                ControllerContext.ActionDescriptor.AttributeRouteInfo?.Template;
            var path = Request.Path.Value;

            return Content($"Path: {path} fullname: {fullname}  template:{template}");
        }

        public IActionResult List(int? id)
        {
            var path = Request.Path.Value;
            return Content($"Path: {path} ID:{id}");
        }
    }
}
