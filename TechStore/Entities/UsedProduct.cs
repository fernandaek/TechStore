﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TechStore.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag()
        {
            return Name + " (USED) $" + Price.ToString("F2") + " Manufactured date " + ManufactureDate;
        }
    }
}
