using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,
                    ProductName="Bardak",UnitePrice=15,
                    UnitINSTock=15},
                new Product{ProductId=2,CategoryId=1,
                    ProductName="Kamera",UnitePrice=500,
                    UnitINSTock=3},
                new Product{ProductId=3,CategoryId=2,
                    ProductName="Telefon",UnitePrice=1500,
                    UnitINSTock=2},
                new Product{ProductId=4,CategoryId=2,
                    ProductName="Klavye",UnitePrice=150,
                    UnitINSTock=65},
                new Product{ProductId=5,CategoryId=2,
                    ProductName="Fare",UnitePrice=85,
                    UnitINSTock=1}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = 
                _products.
                SingleOrDefault(x => x.ProductId == product.ProductId);

            _products.Remove(productToDelete);
            
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p=>p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productUpdate =
                _products.
                SingleOrDefault(x => x.ProductId == product.ProductId);

            productUpdate.ProductName = product.ProductName;
            productUpdate.CategoryId = product.CategoryId;
            productUpdate.UnitePrice = product.UnitePrice;
            productUpdate.UnitINSTock = product.UnitINSTock;
        }
    }
}
