using IsTakip.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Concrete
{
    public class Mission : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool Statu { get; set; }

        public Nullable<int> AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

        public int ImmediateId { get; set; }
        public Immediate Immediate { get; set; } // Aciliyet durumu


        public List<Report> Reports { get; set; }
    }
}
