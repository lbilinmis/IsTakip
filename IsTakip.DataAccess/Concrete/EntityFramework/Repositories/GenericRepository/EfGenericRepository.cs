using IsTakip.DataAccess.Interfaces.GenericRepository;
using IsTakip.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.DataAccess.Concrete.EntityFramework.Repositories.GenericRepository
{
    public class EfGenericRepository<Table, Context> : IGenericDal<Table>
        where Table : class, ITable, new()
        where Context : DbContext, new()

    {
        public void Add(Table entity)
        {
            using (var context=new Context())
            {
                context.Set<Table>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Table entity)
        {
            using (var context = new Context())
            {
                context.Set<Table>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<Table> GetAll()
        {
            using (var context = new Context())
            {
               return  context.Set<Table>().ToList();
               
            }
        }

        public Table GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<Table>().Find(id);
            }
        }

        public void Update(Table entity)
        {
            using (var context = new Context())
            {
                context.Set<Table>().Update(entity);
                context.SaveChanges();
            }
        }
    }
}
