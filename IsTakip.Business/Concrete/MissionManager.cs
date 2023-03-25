using IsTakip.Business.Interfaces;
using IsTakip.DataAccess.Concrete.EntityFramework.Repositories;
using IsTakip.DataAccess.Interfaces;
using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsTakip.Business.Concrete
{
    public class MissionManager : IMissionService
    {
        private readonly IMissionDal _workingService;

        public MissionManager(IMissionDal workingService)
        {
            _workingService = workingService;
        }

        public void Add(Mission entity)
        {
            _workingService.Add(entity);
        }

        public void Delete(Mission entity)
        {
            _workingService.Delete(entity);

        }

        public List<Mission> GetAll()
        {
            return _workingService.GetAll();

        }

        public List<Mission> GetAllMissionWithAllData()
        {
            return _workingService.GetAllMissionWithAllData();
        }

        public List<Mission> GetAllMissionWithImmediateNotCompleted()
        {
            return _workingService.GetAllMissionWithImmediateNotCompleted();
        }

        public Mission GetById(int id)
        {
            return _workingService.GetById(id);

        }

        public Mission GetMissionById(int id)
        {
            return _workingService.GetMissionById(id);
        }

        public void Update(Mission entity)
        {
            _workingService.Update(entity);

        }
    }
}
