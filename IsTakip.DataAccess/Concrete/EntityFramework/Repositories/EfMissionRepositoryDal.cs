using IsTakip.DataAccess.Concrete.EntityFramework.Contexts;
using IsTakip.DataAccess.Concrete.EntityFramework.Repositories.GenericRepository;
using IsTakip.DataAccess.Interfaces;
using IsTakip.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace IsTakip.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfMissionRepositoryDal : EfGenericRepository<Mission, IsTakipContext>, IMissionDal
    {
        public List<Mission> GetAllMissionWithAllData()
        {
            using (var context = new IsTakipContext())
            {
                return context.Missions.Include(x => x.Immediate).Include(x => x.Reports).Include(x => x.AppUser).ToList();
            }

            //using (var context = new IsTakipContext())
            //{
            //    var query = from x in context.Missions
            //                join xReport in context.Reports on x.Id equals xReport.MissionId
            //                join xUser in context.Users on x.AppUserId equals xUser.Id

            //                select x;

            //    return query.ToList();
            //}
        }

        public List<Mission> GetAllMissionWithImmediateNotCompleted()
        {
            using (var context = new IsTakipContext())
            {
                return context.Missions.Include(x => x.Immediate).ToList();
            }
        }

        public Mission GetMissionById(int id)
        {
            //using (var context = new IsTakipContext())
            //{
            //    return context.Missions.Include(x => x.Immediate).FirstOrDefault(x => x.Statu == false && x.Id == id);
            //}

            using (var context = new IsTakipContext())
            {
                var query = from x in context.Missions
                    
                            join xAciliyet in context.Immediates on x.ImmediateId equals xAciliyet.Id                                         

                            where x.Id == id

                            select new
                            {
                                MainEntity = x,
                                AciliyetData=xAciliyet,
                            };

                var mission = query.Select(x=>x.MainEntity).FirstOrDefault();

                return mission;
            }

        }



    }
}
