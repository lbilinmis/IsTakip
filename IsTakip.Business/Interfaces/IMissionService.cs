﻿using IsTakip.Business.Interfaces.GenericService;
using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Business.Interfaces
{
    public interface IMissionService : IGenericService<Mission>
    {
        List<Mission> GetAllMissionWithImmediateNotCompleted();
        public List<Mission> GetAllMissionWithAllData();
        public Mission GetMissionById(int id);
    }
}
