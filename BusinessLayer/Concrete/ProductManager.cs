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
    public class ProductManager : IGenericService<Product>
    {
        IProductDAL _ProductDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _ProductDAL = productDAL;
        }

        public void Add(Product entity)
        {
            _ProductDAL.Add(entity);
        }

        public void Delete(Product entity)
        {
            _ProductDAL.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _ProductDAL.GetAll();
        }

        public Product GetByID(int id)
        {
            return _ProductDAL.GetByID(id);
        }

        public void Update(Product entity)
        {
            _ProductDAL.Update(entity);
        }
    }
}
