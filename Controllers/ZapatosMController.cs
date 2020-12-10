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
    public class ZapatosMController : Controller
    {
        private readonly ILogger<ZapatosMController> _logger;

        public ZapatosMController(ILogger<ZapatosMController> logger)
        {
            _logger = logger;
        }

        public IActionResult IndexM()
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
