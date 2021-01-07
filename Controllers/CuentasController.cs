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

namespace ProjectProgra2020.Controllers
{
    public class CuentasController : Controller
    {
 
        private ApplicationDbContext _context;
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;



        public CuentasController(
            ApplicationDbContext c,
            UserManager<IdentityUser> um,
            SignInManager<IdentityUser> sim

        ) {
            _context = c;
            _userManager = um;
            _signInManager = sim;

        }
        public IActionResult Register() {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegistroViewModel model) {
            if (ModelState.IsValid) {                
                var user = new IdentityUser();
                user.Id = model.id;
                user.UserName = model.Usuario;
                user.Email = model.Email;
                
                var name = _userManager.Users.FirstOrDefault(i => i.Id == model.id);
                if(name == null){
                    var resultado=_userManager.CreateAsync(user, model.Password);

                        if (resultado.Result == IdentityResult.Success) {
                            _signInManager.SignInAsync(user, false);
                            return RedirectToAction("Index", "Home");
                        }else{
                            foreach (var error in resultado.Result.Errors) {
                                ModelState.AddModelError("error", error.Description);
                            }
                        }
                }else{
                    return RedirectToAction("duplicateUser", "Error");      
                }
            }

            return View(model);
        }

        





        public IActionResult Login() {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model) {
            if (ModelState.IsValid) {
                var resultado = _signInManager.PasswordSignInAsync(model.Usuario, model.Password, false, false);

                if (resultado.Result.Succeeded) {
                    var user = _userManager.Users.FirstOrDefault(item => item.UserName == model.Usuario);
                    return RedirectToAction("Index", "Home");

                }
                else {
                    ModelState.AddModelError("error", "Usuario o contraseña incorrectos");
                
                }
            }

            return View(model);
        }
    }
}