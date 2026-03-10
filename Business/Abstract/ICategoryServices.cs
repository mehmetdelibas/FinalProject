using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryServices
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int categoryId);
        IResult Add(Category category);
    }
}
