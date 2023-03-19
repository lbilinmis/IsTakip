using IsTakip.Business.Interfaces;
using IsTakip.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IsTakip.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IMissionService _missionService;

        public HomeController(IMissionService missionService)
        {
            _missionService = missionService;
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
        public IActionResult SignIn(AppUserAddViewModel entity)
        {
            return View();
        }


    }
}