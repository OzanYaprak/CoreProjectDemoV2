using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer;

namespace DataAccessLayer.EntityFramework
{
    public class EFCustomerDAL : GenericRepository<Customer>, ICustomerDAL
    {
    }
}
