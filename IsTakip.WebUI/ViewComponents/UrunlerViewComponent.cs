using Microsoft.AspNetCore.Mvc;

namespace IsTakip.WebUI.ViewComponents
{
    public class UrunlerViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
