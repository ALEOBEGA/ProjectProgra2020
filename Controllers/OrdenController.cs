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

namespace ProjectProgra2020.Controllers
{
    public class OrdenController : Controller
    {

       private readonly ILogger<ContactoController> _logger;
       private readonly ApplicationDbContext _context;

       private readonly UserManager<IdentityUser> _userManager;


        public OrdenController(ILogger<ContactoController> logger,
            ApplicationDbContext context,
            UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult AddItem(int? id)
        {
            var producto = _context.Productos.Find(id);

            var orderDetail = new OrdenDetail();
            orderDetail.producID = producto.ID;
            orderDetail.Price = producto.Price;
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