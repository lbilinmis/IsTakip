using IsTakip.DataAccess.Interfaces.GenericRepository;
using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.DataAccess.Interfaces
{
    public interface IMissionDal:IGenericDal<Mission>
    {
        List<Mission> GetAllMissionWithImmediateNotCompleted();
    }
}
