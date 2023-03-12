﻿using IsTakip.Business.Interfaces;
using IsTakip.DataAccess.Concrete.EntityFramework.Repositories;
using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsTakip.Business.Concrete
{
    internal class MissionManager : IMissionService
    {
        //private readonly IWorkingService _workingService;
        private readonly EfMissionRepositoryDal _workingService;

        public MissionManager(EfMissionRepositoryDal workingService)
        {
            _workingService = workingService;
        }

        //public WorkingManager(IWorkingService workingService)
        //{
        //    _workingService = workingService;
        //}

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

        public Mission GetById(int id)
        {
            return _workingService.GetById(id);

        }

        public void Update(Mission entity)
        {
            _workingService.Update(entity);

        }
    }
}