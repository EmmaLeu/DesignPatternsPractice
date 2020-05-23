namespace DesignPatterns.Behavioral.Strategy.Sample2
{
    public class SalesOrderLine : IOrderLine
    {
        private readonly int _quantity;

        public SalesOrderLine(IProduct product, int quantity)
        {
            Product = product;
            _quantity = quantity;
        }

        public IProduct Product { get; }

        public long Quantity => _quantity;

        public long Price => Product.Price * _quantity;
    }
}
