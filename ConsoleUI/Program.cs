using Business.Concrete;
using DataAccess.Concrete.EntityFreamwork;



ProductTest();
//CatagoryTest();
//OrderTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine(product.ProductName + " - - " + product.CategoryName);
    }
}

static void CatagoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}

static void OrderTest()
{
    OrderManager orderManager = new OrderManager(new EfOrderDal());
    foreach (var order in orderManager.GetAll())
    {
        Console.WriteLine(order.ShipCity);
    }
}