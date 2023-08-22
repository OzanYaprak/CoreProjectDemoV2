using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class JobManager : IGenericService<Job>
    {
        IJobDAL _JobDAL;

        public JobManager(IJobDAL jobDAL)
        {
            _JobDAL = jobDAL;
        }

        public void Add(Job entity)
        {
            _JobDAL.Add(entity);
        }

        public void Delete(Job entity)
        {
            _JobDAL.Delete(entity);
        }

        public List<Job> GetAll()
        {
            return _JobDAL.GetAll();    
        }

        public Job GetByID(int id)
        {
            return _JobDAL.GetByID(id);
        }

        public void Update(Job entity)
        {
            _JobDAL.Update(entity);
        }
    }
}
