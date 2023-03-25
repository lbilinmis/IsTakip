using IsTakip.Business.Interfaces;
using IsTakip.Entities.Concrete;
using IsTakip.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IsTakip.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMissionService _missionService;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(IMissionService missionService, UserManager<AppUser> userManager = null, SignInManager<AppUser> signInManager = null)
        {
            _missionService = missionService;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(AppUserAddViewModel entity)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    UserName = entity.UserName,
                    Email = entity.Email,
                    Name = entity.Name,
                    SurName = entity.SurName,
                    Picture = ""

                };

                var result = await _userManager.CreateAsync(user, entity.Password);

                if (result.Succeeded)
                {
                    var resultRole = await _userManager.AddToRoleAsync(user, "Member");

                    if (resultRole.Succeeded)
                    {
                        return RedirectToAction("Login");
                    }

                    foreach (var item in resultRole.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

            }


            return View(entity);
        }


        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(AppUserLoginViewModel entity)
        {
            if (ModelState.IsValid)
            {
                var userLogin= await _userManager.FindByNameAsync(entity.UserName);
                if (userLogin!=null)
                {
                    //giriş işlemi signInManager ile yapılıyor

                 var identityResult=  await _signInManager.PasswordSignInAsync(userLogin, entity.Password, entity.RememberMe, false);

                    if (identityResult.Succeeded)
                    {
                       var roller= await _userManager.GetRolesAsync(userLogin);
                        if (roller.Contains("Admin"))
                        {
                            //Admine git
                            return RedirectToAction("Index","Home",new {area="Admin"});
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home", new { area = "Member" });

                        }
                    }
                }

                ModelState.AddModelError("","Kullanıcı adı ya da parola hatalı");
            }
      

            return View(entity);
        }



    }
}