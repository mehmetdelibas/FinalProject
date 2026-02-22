using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryServices
    {
        List<Category> GetAll();
        Category GetById(int categoryId);
    }
}
