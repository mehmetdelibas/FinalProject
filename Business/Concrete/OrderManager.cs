using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal categoryDal)
        {
            _orderDal = categoryDal;
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }
    }
}
