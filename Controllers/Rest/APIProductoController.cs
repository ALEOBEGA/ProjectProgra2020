using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectProgra2020.Models;
using ProjectProgra2020.Data;

namespace ProjectProgra2020.Controllers.Rest
{
   [ApiController]
   [Route("api/productos")]

   public class APIProductoController : ControllerBase 
   {
       private readonly ILogger<APIProductoController> _logger;

       private readonly ApplicationDbContext _context ;
       
       public APIProductoController(ILogger<APIProductoController> logger,
       ApplicationDbContext context)
       {
       _logger = logger;
       _context = context;
       }

   }
}
