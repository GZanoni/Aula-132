namespace Products.Entities
{
    class ImportedProducts : Product
    {
        public double CustomFee { get; set; }

        ImportedProducts()
        {
        }

        public ImportedProducts(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {
            return " $ " + TotalPrice() + " (Custom Fee: $" + CustomFee + ")";
        }
    }
}
