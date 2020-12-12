using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectProgra2020.Models;
using ProjectProgra2020.Data;
using Microsoft.AspNetCore.Identity;
using projectProgra2020.Controllers;
using projectProgra2020.Models;
namespace ProjectProgra2020.Controllers
{
    public class OrdenController : Controller
    {

       private readonly ILogger<InicioController> _logger;
       private readonly ApplicationDbContext _context;

       private readonly UserManager<IdentityUser> _userManager;


        public OrdenController(ILogger<InicioController> logger,
            ApplicationDbContext context,
            UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult AddItem(int? id)
        {
            

            var orderDetail = new OrdenDetail();
            orderDetail.Quantity = 1;
            var name = _userManager.GetUserName(User);
            //if is null please login
            orderDetail.Email=name;
            
            _context.Add(orderDetail);
            _context.SaveChanges();
            return RedirectToAction("Index", "Producto");
        }


    }
}
