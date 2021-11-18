﻿using Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.Concrete
{
    public class Customer:IEntity
    {
        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public string CompanyNmae { get; set; }
        public string City { get; set; }
    }
}
