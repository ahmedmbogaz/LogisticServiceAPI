﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public  class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Qantity { get; set; }
        public int UnitsInStock{ get; set; }
        public decimal Price{ get; set; }
    }
}
