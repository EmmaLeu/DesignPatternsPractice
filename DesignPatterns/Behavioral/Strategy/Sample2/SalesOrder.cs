using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy.Sample2
{
    public class SalesOrder : IOrder
    {
        private List<IOrderLine> _orderLines = new List<IOrderLine>();
        private readonly IPricingStrategy _strategy;

        public SalesOrder(IPricingStrategy strategy)
        {
            _strategy = strategy;
        }

        public long GetPrice()
        {
            long total = 0;
            foreach(var orderLine in _orderLines)
            {
                total += orderLine.Price;
            }

            return total;
        }

        public long GetNetPrice()
        {
            return _strategy.Calculate(this);
        }

        public long GetNetPrice(IPricingStrategy strategy)
        {
            return strategy.Calculate(this);
        }

        public void CreateOrderLine(IProduct product, int quantity)
        {
            _orderLines.Add(new SalesOrderLine(product, quantity));
        }
    }
}
