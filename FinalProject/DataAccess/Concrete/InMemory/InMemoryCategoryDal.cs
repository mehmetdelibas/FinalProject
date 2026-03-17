using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categorys;
        public InMemoryCategoryDal()
        {
            _categorys = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Giyim" },
                new Category{CategoryId=2,CategoryName="Ulaşım" },
                new Category{CategoryId=3,CategoryName="Ayakkabı" },
                new Category{CategoryId=4,CategoryName="Ev Ürünleri" },
                new Category{CategoryId=5,CategoryName="Tekstil" }
            };
        }

        public void Add(Category category)
        {
            _categorys.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryDelete =
                _categorys.
                SingleOrDefault(x => x.CategoryId == category.CategoryId);
            _categorys.Remove(categoryDelete);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _categorys;
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllByCategory(int categoryId)
        {
            return _categorys.Where(x=>x.CategoryId == categoryId).ToList();
        }

        public void Update(Category category)
        {
            Category categoryUpdate =
                _categorys.
                SingleOrDefault(x => x.CategoryId == category.CategoryId);
            
            categoryUpdate.CategoryName=category.CategoryName;
        }
    }
}
