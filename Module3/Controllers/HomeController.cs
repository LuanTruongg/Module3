﻿using Microsoft.AspNetCore.Mvc;
using Module3;

namespace Module3.Application.Admin.Controllers
{
    [NamespaceRoutingConvention("Module3.Application")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
