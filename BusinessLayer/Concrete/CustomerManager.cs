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
    public class CustomerManager : IGenericService<Customer>
    {
        ICustomerDAL _CustomerDAL;

        public CustomerManager(ICustomerDAL customerDAL)
        {
            _CustomerDAL = customerDAL;
        }

        public void Add(Customer entity)
        {
            _CustomerDAL.Add(entity);
        }

        public void Delete(Customer entity)
        {
            _CustomerDAL.Delete(entity);
        }

        public List<Customer> GetAll()
        {
            return _CustomerDAL.GetAll();
        }

        public Customer GetByID(int id)
        {
            return _CustomerDAL.GetByID(id);
        }

        public void Update(Customer entity)
        {
            _CustomerDAL.Update(entity);
        }
    }
}
