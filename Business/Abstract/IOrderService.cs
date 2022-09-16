using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetOrdersByDay();
        IDataResult<List<Order>> GetAll();

        Task<IResult> AddAsync(Order order);
        IResult Update(Order order);
        IResult Delete(Order order);
    }
}
