using IsTakip.Business.Interfaces;
using IsTakip.DataAccess.Interfaces;
using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _userDal;

        public AppUserManager(IAppUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public AppUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetUserMember()
        {
            return _userDal.GetUserMember();
        }

        public List<AppUser> GetUserMember(out int toplamSayfa,string aranacakKelime, int sayfadakacTaneVeri, int aktifSayfa)
        {
            return _userDal.GetUserMember(out toplamSayfa, aranacakKelime, sayfadakacTaneVeri, aktifSayfa);
        }

        public void Update(AppUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
