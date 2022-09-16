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

        public IResult Add(Delivery delivery)
        {
            _deliveryDal.Add(delivery);
            return new SuccessResult(Messages.DeliveryAdded);
        }
    }
}
