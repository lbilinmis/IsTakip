using IsTakip.Business.Interfaces;
using IsTakip.DataAccess.Concrete.EntityFramework.Repositories;
using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Business.Concrete
{
    internal class WorkingManager : IWorkingService
    {
        //private readonly IWorkingService _workingService;
        private readonly EfWorkingRepositoryDal _workingService;

        public WorkingManager(EfWorkingRepositoryDal workingService)
        {
            _workingService = workingService;
        }

        //public WorkingManager(IWorkingService workingService)
        //{
        //    _workingService = workingService;
        //}

        public void Add(Working entity)
        {
            _workingService.Add(entity);
        }

        public void Delete(Working entity)
        {
            _workingService.Delete(entity);

        }

        public List<Working> GetAll()
        {
            return _workingService.GetAll();

        }

        public Working GetById(int id)
        {
            return _workingService.GetById(id);

        }

        public void Update(Working entity)
        {
            _workingService.Update(entity);

        }
    }
}
