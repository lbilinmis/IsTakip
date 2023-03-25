using IsTakip.Business.Interfaces;
using IsTakip.Entities.Concrete;
using IsTakip.WebUI.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace IsTakip.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class IsEmriController : Controller
    {
        private readonly IAppUserService _appUserService ;
        private readonly IMissionService _missionService;

        public IsEmriController(IAppUserService appUserService, IMissionService missionService)
        {
            _appUserService = appUserService;
            _missionService = missionService;
        }

        public IActionResult Index()
        {
            //List<AppUser> memberUsers = new List<AppUser>();
            //memberUsers = _appUserService.GetUserMember();

            //return View(memberUsers);

            List<Mission> list = new List<Mission>();
            List<ViewModelGorevAllData> listModels = new List<ViewModelGorevAllData>();
            list = _missionService.GetAllMissionWithAllData();

            foreach (var item in list)
            {
                ViewModelGorevAllData model = new ViewModelGorevAllData();
                model.Name = item.Name;
                model.Description = item.Description;   
                model.Id=item.Id;
                model.Immediate=item.Immediate;
                model.CreatedTime=item.CreatedTime;
                model.Reports = item.Reports;
                model.AppUser = item.AppUser;
                listModels.Add(model);  

            }

            return View(listModels);
        }


        public IActionResult PersonelAta(int id,string aranacak,int sayfa=1)
        {
            var model = _missionService.GetMissionById(id);

            ViewBag.AktifSayfa = sayfa;
            //int personelToplam= _appUserService.GetUserMember().Count;
            //ViewBag.ToplamSayfa = Math.Ceiling((double)personelToplam / 3);

            int toplamSayfa;
            var personeller = _appUserService.GetUserMember(out toplamSayfa, aranacakKelime: aranacak, sayfadakacTaneVeri: 4, sayfa);
            ViewBag.ToplamSayfa=toplamSayfa;
            List<ViewModelAppUserMember> personelList=new List<ViewModelAppUserMember>();
            foreach (var item in personeller)
            {
                ViewModelAppUserMember pers = new ViewModelAppUserMember();
                pers.Name = item.Name;
                pers.Email = item.Email;
                pers.Picture = item.Picture;
                pers.SurName= item.SurName;
                pers.Id=item.Id;

                personelList.Add(pers);
            }

            ViewBag.Personeller = personelList;
            ViewModelGorev gorevModel = new ViewModelGorev();
            gorevModel.Name = model.Name;
            gorevModel.Description = model.Description;
            gorevModel.Id = model.Id;
            gorevModel.Immediate = model.Immediate;
            gorevModel.CreatedTime = model.CreatedTime;



            return View(gorevModel);
        }
    }
}
