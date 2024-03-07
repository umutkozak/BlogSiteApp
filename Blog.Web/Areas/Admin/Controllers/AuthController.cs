using Blog.Entity.Entities;
using Blog.Entity.ViewModel.Admin;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AuthController : Controller
    {
        private readonly Microsoft.AspNetCore.Identity.UserManager<AppUser> _usermanager;

        private readonly SignInManager<AppUser> signInManager;
        public AuthController(Microsoft.AspNetCore.Identity.UserManager<AppUser> usermanager,SignInManager<AppUser> signInManager)
        {
            _usermanager = usermanager;
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(AdminVM vm)
        {
            if (ModelState.IsValid) 
            {
                var user=await _usermanager.FindByEmailAsync(vm.Email);
                if (user != null) 
                {
                    var result=await signInManager.PasswordSignInAsync(user, vm.Password,vm.RememberMe,false);
                    if (result.Succeeded) 
                    {
                        return RedirectToAction("Index", "Admin",new {Area="Admin"});
                    }
                    else
                    {
                        ModelState.AddModelError("", "E-Posta adresi veya şifre hatalı");
                        return View();
                    }
               
                }
                else
                {
                    ModelState.AddModelError("", "E-Posta adresi veya şifre hatalı");
                    return View();
                }
            }
            return View();
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Logout() 
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home" ,new { Area = "" });
        }
    }
}
