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
    public class EfUserRepositoryDal : IUserDal
    {
        public void Add(User entity)
        {
            using (var context = new IsTakipContext())
            {
                context.Users.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(User entity)
        {
            using (var context = new IsTakipContext())
            {
                context.Users.Remove(entity);
                context.SaveChanges();
            }
        }

        public List<User> GetAll()
        {
            using (var context = new IsTakipContext())
            {
                return context.Users.ToList();
            }
        }

        public User GetById(int id)
        {
            using (var context = new IsTakipContext())
            {
               return context.Users.Find(id);
            }
        }

        public void Update(User entity)
        {
            using (var context = new IsTakipContext())
            {
                context.Users.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
