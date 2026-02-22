using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryServices
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //iş kodları, Yetki kontorlü
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryiId)
        {
            return _categoryDal.Get(p=>p.CategoryId == categoryiId);
        }
    }
}
