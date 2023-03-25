using IsTakip.DataAccess.Concrete.EntityFramework.Contexts;
using IsTakip.DataAccess.Concrete.EntityFramework.Repositories.GenericRepository;
using IsTakip.DataAccess.Interfaces;
using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfAppUserRepositoryDal : EfGenericRepository<AppUser, IsTakipContext>, IAppUserDal
    {
        public List<AppUser> GetUserMember(out int toplamSayfa, string aranacakKelime = "", int sayfadakacTaneVeri=4, int aktifSayfa = 1)
        {
            using var context = new IsTakipContext();

            var query = from x in context.Users
                        join xUserRole in context.UserRoles on x.Id equals xUserRole.UserId
                        join xRoles in context.Roles on xUserRole.RoleId equals xRoles.Id
                        where xRoles.Name == "Member"

                        select new
                        {
                            MainData = x,
                            UserRoleData = xUserRole,
                            RoleData = xRoles
                        };

            toplamSayfa=(int) Math.Ceiling((double)query.Count() / 3);
            if (!string.IsNullOrWhiteSpace(aranacakKelime))
            {
                query = query.Where(x => x.MainData.Name.ToLower().Contains(aranacakKelime.ToLower()) || x.MainData.SurName.ToLower().Contains(aranacakKelime.ToLower()));

                toplamSayfa = (int)Math.Ceiling((double)query.Count() / 3);
            }

            query = query.Skip((aktifSayfa - 1) * 4).Take(sayfadakacTaneVeri);

            var list = query.ToList();

            return list.Select(x => x.MainData).ToList();
        }

        public List<AppUser> GetUserMember()
        {
            using var context = new IsTakipContext();

            var query = from x in context.Users
                        join xUserRole in context.UserRoles on x.Id equals xUserRole.UserId
                        join xRoles in context.Roles on xUserRole.RoleId equals xRoles.Id
                        where xRoles.Name == "Member"

                        select new
                        {
                            MainData = x,
                            UserRoleData = xUserRole,
                            RoleData = xRoles
                        };


            var list = query.ToList();

            return list.Select(x => x.MainData).ToList();
        }

    }
}
