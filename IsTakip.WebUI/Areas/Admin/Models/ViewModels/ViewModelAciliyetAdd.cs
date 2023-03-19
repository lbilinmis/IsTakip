using System.ComponentModel.DataAnnotations;

namespace IsTakip.WebUI.Areas.Admin.Models.ViewModels
{
    public class ViewModelAciliyetAdd
    {
        [Display(Name ="Tanım")]
        [Required(ErrorMessage ="Tanım alanı boş geçilemez")]
        public string Title { get; set; }

    }
}
