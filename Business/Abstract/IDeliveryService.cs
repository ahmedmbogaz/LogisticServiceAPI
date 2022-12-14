using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDeliveryService
    {
        IDataResult<List<Delivery>> GetAll();
        Task<IResult> AddAsync(Delivery delivery);
        IResult Update(Delivery delivery);
        IResult Delete(Delivery delivery);
    }
}
