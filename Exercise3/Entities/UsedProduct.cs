using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManuFacture { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manuFacture) :base(name, price)
        {
            ManuFacture = manuFacture.Date;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) ${Price} (Manufacture date: {ManuFacture})";
        }
    }
}
