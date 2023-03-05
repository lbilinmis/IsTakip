using IsTakip.DataAccess.Concrete.EntityFramework.Contexts;
using IsTakip.DataAccess.Interfaces;
using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfWorkingRepositoryDal : IWorkingDal
    {
        public void Add(Working entity)
        {
            using (var context=new IsTakipContext())
            {
                //context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                //context.Workings.Add(entity);

                context.Workings.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Working entity)
        {
            using (var context = new IsTakipContext())
            {
                //context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                //context.Workings.Remove(entity);

                context.Workings.Remove(entity);
                context.SaveChanges();

            }
        }

        public List<Working> GetAll()
        {
            using (var context = new IsTakipContext())
            {
                return context.Workings.ToList();
            }
        }

        public Working GetById(int id)
        {
            using (var context = new IsTakipContext())
            {
                return context.Workings.Find(id);
            }
        }

        public void Update(Working entity)
        {
            using (var context = new IsTakipContext())
            {
                //context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                //context.Workings.Update(entity);
                context.Workings.Update(entity);

                context.SaveChanges();

            }
        }
    }
}
