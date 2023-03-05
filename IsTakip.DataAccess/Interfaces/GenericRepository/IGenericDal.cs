using IsTakip.Entities.Concrete;
using IsTakip.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.DataAccess.Interfaces.GenericRepository
{
    public interface IGenericDal<Table> where Table : class, ITable, new()
    {
        void Add(Table entity);
        void Delete(Table entity);
        void Update(Table entity);
        List<Table> GetAll();
        Table GetById(int id);
    }
}
