using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal iProductDal)
        {
            _productDal = iProductDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları, Yetki kontorlü
            return _productDal.GetAll();
        }
    }
}
