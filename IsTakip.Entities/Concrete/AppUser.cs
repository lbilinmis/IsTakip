using IsTakip.Entities.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Entities.Concrete
{
    public class AppUser : IdentityUser<int>,ITable
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Picture { get; set; }

        public List<Mission> Missions { get; set; }
    }
}
