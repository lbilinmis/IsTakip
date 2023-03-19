using IsTakip.Entities.Concrete;

namespace IsTakip.WebUI.Areas.Admin.Models.ViewModels
{
    public class ViewModelGorev
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool Statu { get; set; }

        public int ImmediateId { get; set; }
        public Immediate Immediate { get; set; } // Aciliyet durumu

    }
}
