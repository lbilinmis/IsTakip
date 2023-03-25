using IsTakip.Business.Interfaces.GenericService;
using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Business.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        List<AppUser> GetUserMember();
        List<AppUser> GetUserMember(out int toplamSayfa, string aranacakKelime, int sayfadakacTaneVeri, int aktifSayfa);
    }
}

