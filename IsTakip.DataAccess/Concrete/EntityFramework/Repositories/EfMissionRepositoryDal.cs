using IsTakip.DataAccess.Concrete.EntityFramework.Contexts;
using IsTakip.DataAccess.Concrete.EntityFramework.Repositories.GenericRepository;
using IsTakip.DataAccess.Interfaces;
using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsTakip.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfMissionRepositoryDal : EfGenericRepository<Mission, IsTakipContext>, IMissionDal
    {
    }
}
