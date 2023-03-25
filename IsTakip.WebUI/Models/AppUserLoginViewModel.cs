using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace IsTakip.WebUI.Models
{
    public class AppUserLoginViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Kullanıcı parolası boş geçilemez")]
        [Display(Name = "Parola")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }

    }
}
