using System.ComponentModel.DataAnnotations;

namespace IsTakip.WebUI.Models
{
    public class AppUserAddViewModel
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez")]
        [Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Kullanıcı parolası boş geçilemez")]
        [Display(Name = "Parola")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Kullanıcı parolası eşleşmedi")]
        [Display(Name = "Parola Tekrar")]
        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Kullanıcı emaili boş geçilemez")]
        [Display(Name = "Email")]

        [EmailAddress(ErrorMessage ="Geçersiz email adresi")] 
        public string Email{ get; set; }

        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
        [Display(Name = "Adınız")]

        public string Name{ get; set; }

        [Display(Name ="Soyadınız")]
        [Required(ErrorMessage = "Kullanıcı soyadı boş geçilemez")]
        public string SurName{ get; set; }
    }
}
