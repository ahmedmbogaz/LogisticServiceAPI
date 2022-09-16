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
    public class DeliveryManager : IDeliveryService
    {
        IDeliveryDal _deliveryDal;

        public DeliveryManager(IDeliveryDal deliveryDal)
        {
            _deliveryDal = deliveryDal;
        }

        public async Task<IResult> AddAsync(Delivery delivery)
        {
            await _deliveryDal.AddAsync(delivery);
            return new SuccessResult(Messages.DeliveryAdded);
        }

        public IResult Delete(Delivery delivery)
        {
            _deliveryDal.Delete(delivery);
            return new SuccessResult(Messages.DeliveryDelete);
        }

        public IDataResult<List<Delivery>> GetAll()
        {
            return new SuccessDataResult<List<Delivery>>(_deliveryDal.GetAll(), Messages.DeliveriesListed);
        }

        public IResult Update(Delivery delivery)
        {
            _deliveryDal.Update(delivery);
            return new SuccessResult(Messages.DeliveryUpdate);
        }
    }
}
