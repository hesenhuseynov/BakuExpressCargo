﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakuExpressCargo.Domain.Entities
{
    public  class Customer
    {
        public int Id { get; set; }

        public string Name  { get; set; }


        public string PhoneNumber { get; set; }

        public Adress Adress { get; set; }
    }
}
