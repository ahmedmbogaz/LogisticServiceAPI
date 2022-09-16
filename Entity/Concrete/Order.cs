using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public DateTime OrderTime { get; set; }
        public int ProductId { get; set; }
        public int AddressId { get; set; }
        public string PhoneNumber { get; set; }
        public string ReceivedCustomerName { get; set; }
        public Status Status { get; set; }

    }

    public enum Status
    {
        Waiting=0, Delivered=1,Complated=2
    }
}
