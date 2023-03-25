using IsTakip.Business.Interfaces;
using IsTakip.Entities.Concrete;
using IsTakip.WebUI.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IsTakip.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles ="Admin")]
    [Area("Admin")]
    public class AciliyetController : Controller
    {
        private readonly IImmediateService _immediateService;

        public AciliyetController(IImmediateService immediateService)
        {
            _immediateService = immediateService;
        }

        public IActionResult Index()
        {
            List<Immediate> list = _immediateService.GetAll();
            List<ViewModelAciliyet> aciliyetList = new List<ViewModelAciliyet>();

            foreach (var item in list)
            {
                ViewModelAciliyet ac = new ViewModelAciliyet();
                ac.Id = item.Id;
                ac.Title = item.Title;

                aciliyetList.Add(ac);
            }

            return View(aciliyetList);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ViewModelAciliyetAdd entity)
        {
            if (ModelState.IsValid)
            {
                Immediate immediate = new Immediate();
                immediate.Title = entity.Title;

                _immediateService.Add(immediate);

                return RedirectToAction("Index");
            }

            return View(entity);
        }


        public IActionResult Update(int id)
        {
            var aciliyet = _immediateService.GetById(id);
            ViewModelAciliyetUpdate model = new ViewModelAciliyetUpdate();
            model.Id = aciliyet.Id;
            model.Title = aciliyet.Title;
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(ViewModelAciliyetUpdate entity)
        {
            if (ModelState.IsValid)
            {
                Immediate immediate = new Immediate();
                immediate.Title = entity.Title;
                immediate.Id = entity.Id;

                _immediateService.Update(immediate);

                return RedirectToAction("Index");
            }

            return View(entity);
        }
    }
}
