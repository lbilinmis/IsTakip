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
    public class ReportManager : IReportService
    {
        private readonly IReportDal _reportDal;

        public ReportManager(IReportDal reportDal)
        {
            _reportDal = reportDal;
        }

        public void Add(Report entity)
        {
            _reportDal.Add(entity);
        }

        public void Delete(Report entity)
        {
            _reportDal.Delete(entity);
        }

        public List<Report> GetAll()
        {
            return  _reportDal.GetAll();
        }

        public Report GetById(int id)
        {
            return _reportDal.GetById(id);
        }

        public void Update(Report entity)
        {
             _reportDal.Update(entity);
        }
    }
}
