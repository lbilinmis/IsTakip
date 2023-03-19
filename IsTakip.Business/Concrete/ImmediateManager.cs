using IsTakip.Business.Interfaces;
using IsTakip.DataAccess.Concrete.EntityFramework.Repositories;
using IsTakip.DataAccess.Interfaces;
using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Business.Concrete
{
    public class ImmediateManager : IImmediateService
    {
        private readonly IImmediateDal _immediateDal;

        public ImmediateManager(IImmediateDal immediateDal)
        {
            _immediateDal = immediateDal;
        }

        public void Add(Immediate entity)
        {
            _immediateDal.Add(entity);
        }

        public void Delete(Immediate entity)
        {
            _immediateDal.Delete(entity);

        }

        public List<Immediate> GetAll()
        {
            return _immediateDal.GetAll();
        }

        public Immediate GetById(int id)
        {
            return _immediateDal.GetById(id);
        }

        public void Update(Immediate entity)
        {
            _immediateDal.Update(entity);
        }
    }
}
