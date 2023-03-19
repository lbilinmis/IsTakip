using IsTakip.Entities.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace IsTakip.WebUI.Areas.Admin.Models.ViewModels
{
    public class ViewModelGorevAdd
    {
        [Display(Name = "Görev Adı")]
        [Required(ErrorMessage = "Görev adı boş geçilemez")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama alanı boş geçilemez")]
        public string Description { get; set; }

        //[Display(Name = "Durumu")]
        //public bool Statu { get; set; }

        [Range(0,int.MaxValue, ErrorMessage = "Lütfen aciliyet durumunu seçiniz")]
        [Display(Name = "Aciliyet Durumu")]
        public int ImmediateId { get; set; }

        //public SelectList  AciliyetListesi{ get; set; }

    }
}
