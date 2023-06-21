using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Module3.DI;

namespace Module3.Controllers
{
    public class SettingsController : Controller
    {
        private readonly SampleWebSettings _settingsOptions;

        public SettingsController(IOptions<SampleWebSettings> settingsOptions)
        {
            _settingsOptions = settingsOptions.Value;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = _settingsOptions.Title;
            ViewData["Updates"] = _settingsOptions.Updates;
            return View();
        }
    }
}
