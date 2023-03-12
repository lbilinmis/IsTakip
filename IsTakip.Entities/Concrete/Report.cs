using IsTakip.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Concrete
{
    public class Report : ITable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int MissionId { get; set; }
        public Mission Mission { get; set; }

    }
}
