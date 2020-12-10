using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectProgra2020.Models;

namespace projectProgra2020.Controllers
{
    public class ZapatosNController : Controller
    {
        private readonly ILogger<ZapatosNController> _logger;

        public ZapatosNController(ILogger<ZapatosNController> logger)
        {
            _logger = logger;
        }

        public IActionResult IndexN()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
