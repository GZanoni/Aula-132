using System;

namespace Products.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            return " (used) " + base.PriceTag() + " (Manufactured date: " + ManufacturedDate.ToString("dd/MM/yyyy") + ")";
        }

    }
}
