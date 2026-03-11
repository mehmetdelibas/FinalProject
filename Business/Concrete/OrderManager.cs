using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFreamwork;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult Add(Order order)
        {
            ValidationTool.Validate(new OrderValidator(), order);
            _orderDal.Add(order);
            return new SuccessResult(Messages.OrderAdded);
        }

        public IDataResult<List<Order>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
                return new ErrorDataResult<List<Order>>(Messages.MaintenanceTime);

            //iş kodları, Yetki kontorlü
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll().OrderBy(p => p.OrderID).ToList(), Messages.OrderListed);
        }
    }
}
