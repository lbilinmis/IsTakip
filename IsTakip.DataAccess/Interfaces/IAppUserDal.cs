using IsTakip.DataAccess.Interfaces.GenericRepository;
using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.DataAccess.Interfaces
{
    public interface IAppUserDal : IGenericDal<AppUser>
    {
        List<AppUser> GetUserMember();
        List<AppUser> GetUserMember(out int toplamSayfa,string aranacakKelime,int sayfadakacTaneVeri, int aktifSayfa=1);
    }
}
