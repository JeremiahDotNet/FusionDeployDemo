using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FusionDeployDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var version = Microsoft.Extensions.PlatformAbstractions
                .PlatformServices.Default.Application
                .ApplicationVersion;

            ViewData["Version"] = version;

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
