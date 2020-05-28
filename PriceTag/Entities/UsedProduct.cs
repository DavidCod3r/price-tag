using System;
using System.Collections.Generic;
using System.Text;

namespace PriceTag.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime monufactureDate) : base(name, price)
        {
            ManufactureDate = ManufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag();
        }
    }
}
