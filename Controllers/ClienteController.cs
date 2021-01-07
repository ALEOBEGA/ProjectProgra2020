using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectProgra2020.Models;
using ProjectProgra2020.Data;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;


namespace ProjectProgra2020.Controllers
{
    public class ClienteController : Controller
    {

        private ApplicationDbContext _context;
        private DBcarritoContext  _DBcarritoContext;
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;



        public ClienteController(
            ApplicationDbContext c,
            DBcarritoContext car,
            UserManager<IdentityUser> um,
            SignInManager<IdentityUser> sim

        ) {
            _context = c;
            _userManager = um;
            _signInManager = sim;

            _DBcarritoContext = car;
        }
        public IActionResult producto()
        {
            var productos=_context.producto.ToList();
            
            return View(productos);
        }
        public IActionResult Reporte()
        {
            var Ventas=_context.ventas.ToList();
            
            return View(Ventas);
        }
        public IActionResult Confirmacion()
        {        
            return View();
        }
                public IActionResult Catalogo()
        {
            var productos=_context.producto.ToList();
            
            return View(productos);
        }
        public IActionResult carrito()
        {

            var listar=_DBcarritoContext.Carrito_de_compras.ToList();
            foreach(var x in listar){
                Carrito_de_compras carrito=new Carrito_de_compras();
                var precPro= _context.producto.FirstOrDefault(item => item.idproducto == int.Parse(x.id));
                x.precio=precPro.precio*x.cant;
                _DBcarritoContext.Carrito_de_compras.Update(x);   
                _DBcarritoContext.SaveChanges();

            }
            var resultado=_DBcarritoContext.Carrito_de_compras.ToList();
            return View(resultado);
        }

        [HttpPost]
        public IActionResult AgregarAlCarrito(int id_producto,int cant_en_stock)
        {   
                 Console.WriteLine("IDPRODUCTO============="+id_producto);
                 Console.WriteLine("CANTIDAD DE REGISTROS============="+_DBcarritoContext.Carrito_de_compras.Count());
            var comp= _DBcarritoContext.Carrito_de_compras.FirstOrDefault(item => item.id==id_producto+"");
                
            if(comp==null){
                Carrito_de_compras objCarrito2=new Carrito_de_compras();
                var entity = _context.producto.FirstOrDefault(item => item.idproducto ==id_producto );

                objCarrito2.id=id_producto+"";
                objCarrito2.nombre=entity.nombre;
                objCarrito2.precio=entity.precio;
                objCarrito2.descripcion=entity.descripcion;
                objCarrito2.imagen=entity.imagen;
                objCarrito2.categoria=entity.categoria;
                objCarrito2.cant=cant_en_stock;

            
                _DBcarritoContext.Carrito_de_compras.Add(objCarrito2);
                _DBcarritoContext.SaveChanges();
            }else{
                Carrito_de_compras c=new Carrito_de_compras();
                c= _DBcarritoContext.Carrito_de_compras.FirstOrDefault(item => item.id ==id_producto+"");
                Console.WriteLine("cantidaaaaaaaaaaaaaaaad"+c.cant);
                Console.WriteLine("cantidaaaaaaaaaaaaaaaad2"+cant_en_stock);
                c.cant=c.cant+cant_en_stock;
                Console.WriteLine("cantidaaaaaaaaaaaaaaaad3"+c.cant);
                
                _DBcarritoContext.Carrito_de_compras.Update(c);   
                _DBcarritoContext.SaveChanges();
            
            }
            return RedirectToAction("producto","Cliente");         
        }

        [HttpPost]
        public async Task<IActionResult> cotizacion(ICollection<int> idP,ICollection<int> cantP)
        {   
           var user = await _userManager.GetUserAsync(HttpContext.User);
        var c= _userManager.Users.FirstOrDefault(item => item.UserName ==user+"");
        int v1=0;
            foreach(var produc in idP){
                var precPro= _context.producto.FirstOrDefault(item => item.idproducto ==produc);
                var v2=0;
                foreach(var cantidad in cantP){
                    
                    if(v1==v2){
                        ventas ventas=new ventas();
                        ventas.idventas = _context.ventas.Count()+1;
                        ventas.idcliente=c.Id;
                        ventas.idproducto=produc;
                        ventas.fechaventa=DateTime.Today;
                        ventas.preciot=precPro.precio*cantidad;
                        ventas.cantidad=cantidad;
                        _context.ventas.Add(ventas);
                        
                    }
                    v2++;
                _context.SaveChanges();
                }
                
                v1++;
            }
        
        
             return RedirectToAction ("Confirmacion","Cliente");


           
        }
        

        [HttpPost]
        public IActionResult DELETE(ICollection<int> idP)
        {   
            foreach(var i in idP){
                var x= _DBcarritoContext.Carrito_de_compras.FirstOrDefault(item => item.id == i+"");
                _DBcarritoContext.Remove(x);
            }
            _DBcarritoContext.SaveChanges();
                        return RedirectToAction ("carrito","Cliente");
           
        }
        

        [HttpPost]
                public async Task<IActionResult> Comprar(int id_producto){
                    var user = await _userManager.GetUserAsync(HttpContext.User);
                    var c= _userManager.Users.FirstOrDefault(item => item.UserName ==user+"");
                    var precPro= _context.producto.FirstOrDefault(item => item.idproducto ==id_producto);
                        ventas ventas=new ventas();
                        ventas.idventas = _context.ventas.Count()+1;
                        ventas.idcliente=c.Id;
                        ventas.idproducto=id_producto;
                        ventas.fechaventa=DateTime.Today;
                        ventas.preciot=precPro.precio;
                        ventas.cantidad=1;
                        _context.ventas.Add(ventas);
                        _context.SaveChanges(); 
                        return RedirectToAction ("Confirmacion","Cliente");
           
        


        }
    }
}
