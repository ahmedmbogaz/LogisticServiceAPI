using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Delivery:IEntity
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public DateTime DeliveredTime { get; set; }
        public string NumberPlate  { get; set; }
        public string DeliveredPersonalName { get; set; }
    }
}
