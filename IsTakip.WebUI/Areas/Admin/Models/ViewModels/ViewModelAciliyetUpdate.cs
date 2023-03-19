using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace IsTakip.WebUI.Areas.Admin.Models.ViewModels
{
    public class ViewModelAciliyetUpdate
    {
        public int Id { get; set; }
        [Display(Name = "Tanım")]
        [Required(ErrorMessage = "Tanım alanı boş geçilemez")]
        public string Title { get; set; }
    }
}
