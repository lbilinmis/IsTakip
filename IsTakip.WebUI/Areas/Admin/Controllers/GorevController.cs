using IsTakip.Business.Interfaces;
using IsTakip.Entities.Concrete;
using IsTakip.WebUI.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IsTakip.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GorevController : Controller
    {
        private readonly IMissionService _missionService;
        private readonly IImmediateService _immediateService;
        public GorevController(IMissionService missionService, IImmediateService immediateService)
        {
            _missionService = missionService;
            _immediateService = immediateService;
        }

        public IActionResult Index()
        {
            List<Mission> list = _missionService.GetAllMissionWithImmediateNotCompleted();
            List<ViewModelGorev> gorevListesi = new List<ViewModelGorev>();
            foreach (var item in list)
            {
                ViewModelGorev gorev = new ViewModelGorev();
                gorev.Immediate=item.Immediate;
                gorev.Name = item.Name;
                gorev.Description = item.Description;
                gorev.CreatedTime = item.CreatedTime;
                gorev.ImmediateId = item.ImmediateId;
                gorev.Id = item.Id;
                gorev.Statu = item.Statu;

                gorevListesi.Add(gorev);
            }
            return View(gorevListesi);
        }


        public IActionResult Create()
        {
            ViewModelGorevAdd viewModelGorevAdd = new ViewModelGorevAdd();
            //viewModelGorevAdd.AciliyetListesi = new SelectList(_immediateService.GetAll(), "Id", "Title");
            ViewBag.AciliyetListesi = new SelectList(_immediateService.GetAll(), "Id", "Title");

            return View(viewModelGorevAdd);
        }

        [HttpPost]
        public IActionResult Create(ViewModelGorevAdd entity)
        {
            if (ModelState.IsValid)
            {
                Mission mission = new Mission();
                mission.Name = entity.Name;
                mission.Description = entity.Description;
                mission.CreatedTime=DateTime.Now;
                mission.ImmediateId = entity.ImmediateId;
                mission.Statu = true;

                _missionService.Add(mission);

                return RedirectToAction("Index");
            }

            return View(entity);
        }


        public IActionResult Update(int id)
        {
            var gorev = _missionService.GetById(id);
            ViewModelGorevUpdate model = new ViewModelGorevUpdate();
            model.Id = gorev.Id;
            model.Name = gorev.Name;
            model.Description = gorev.Description;
            model.ImmediateId=gorev.ImmediateId;
            

            ViewBag.AciliyetListesi = new SelectList(_immediateService.GetAll(), "Id", "Title",gorev.ImmediateId);

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(ViewModelGorevUpdate gorev)
        {
            if (ModelState.IsValid)
            {
                Mission model = new Mission();
                model.Id = gorev.Id;
                model.Name = gorev.Name;
                model.Description = gorev.Description;
                model.ImmediateId = gorev.ImmediateId;

                _missionService.Update(model);

                return RedirectToAction("Index");
            }

            return View(gorev);
        }

        public IActionResult Delete(int id)
        {
            var gorev = _missionService.GetById(id);

            if (gorev!=null)
            {
                _missionService.Delete(gorev);
                return Json(null);
            }
            return Json(null);
        }
    }
}
