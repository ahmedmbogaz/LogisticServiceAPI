using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public async Task<IResult> AddAsync(Order order)
        {
            await _orderDal.AddAsync(order);

            return new SuccessResult(Messages.OrderAdded);
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult(Messages.OrderDelete);
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(), Messages.OrdersListed);
        }

        public IDataResult<List<Order>> GetOrdersByDay()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll()
                .Where(p=>p.OrderTime.AddDays(1)>=DateTime.Now).ToList(), Messages.OrderDay);
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return  new  SuccessResult (Messages.OrderUpdate);
        }
    }
}
