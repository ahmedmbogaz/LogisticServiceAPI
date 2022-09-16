﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Address:IEntity
    {
        public int Id { get; set; }
        public string City { get; set; }
    }
}