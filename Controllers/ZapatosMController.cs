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
using ProjectProgra2020.Data;

namespace ProjectProgra2020.Controllers
{
    public class ZapatosMController : Controller
    {
        
        private readonly ILogger<ZapatosMController> _logger;

        private readonly ApplicationDbContext _context;

        public ZapatosMController(ILogger<ZapatosMController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult IndexM()
        {
            var listContactos=_context.producto.ToList();

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
