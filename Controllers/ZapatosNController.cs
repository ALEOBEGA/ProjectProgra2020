using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectProgra2020.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ProjectProgra2020.Controllers
{
    public class ZapatosNController : Controller
    {
        
        private readonly ILogger<ZapatosNController> _logger;

        private readonly DatabaseContext _context;

        public ZapatosNController(ILogger<ZapatosNController> logger,DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult IndexN()
        {
            var listContactos=_context.producton.ToList();

            return View(listContactos);
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
