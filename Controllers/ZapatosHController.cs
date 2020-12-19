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
using ProjectProgra2020.Controllers;

namespace ProjectProgra2020.Controllers
{
    public class ZapatosHController : Controller
    {
        
        private readonly ILogger<ZapatosHController> _logger;

        private readonly DatabaseContext _context;

        public ZapatosHController(ILogger<ZapatosHController> logger,DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult IndexH()
        {
            var listProductos=_context.producto.ToList();

            return View(listProductos);
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
