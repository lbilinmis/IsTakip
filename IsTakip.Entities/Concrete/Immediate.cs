using IsTakip.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Concrete
{
    public class Immediate : ITable
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<Mission> Missions { get; set; }
    }
}
