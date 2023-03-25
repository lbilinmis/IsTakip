using IsTakip.Entities.Concrete;

namespace IsTakip.WebUI.Areas.Admin.Models.ViewModels
{
    public class ViewModelGorevAllData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public Immediate Immediate { get; set; } 
        public AppUser? AppUser { get; set; }
        public List<Report> Reports { get; set; }
    }
}
