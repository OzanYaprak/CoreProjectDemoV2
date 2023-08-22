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
    public class CategoryManager : IGenericService<Category>
    {
        ICategoryDAL _CategoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _CategoryDAL = categoryDAL;
        }

        public void Add(Category entity)
        {
            _CategoryDAL.Add(entity);
        }

        public void Delete(Category entity)
        {
            _CategoryDAL.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return _CategoryDAL.GetAll();
        }

        public Category GetByID(int id)
        {
            return _CategoryDAL.GetByID(id);
        }

        public void Update(Category entity)
        {
            _CategoryDAL.Update(entity);
        }
    }
}
