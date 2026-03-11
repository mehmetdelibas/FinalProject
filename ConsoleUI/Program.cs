using Business.Concrete;
using DataAccess.Concrete.EntityFreamwork;



ProductTest();
//CatagoryTest();
//OrderTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
    var result = productManager.GetProductDetails();
    if (result.Success==true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + " - - " + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}

static void CatagoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll().Data)
    {
        Console.WriteLine(category.CategoryName);
    }
}
/*
static void OrderTest()
{
    OrderManager orderManager = new OrderManager(new EfOrderDal());
    foreach (var order in orderManager.GetAll())
    {
        Console.WriteLine(order.ShipCity);
    }
}*/