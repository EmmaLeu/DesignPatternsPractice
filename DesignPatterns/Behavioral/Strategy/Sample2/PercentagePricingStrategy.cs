namespace DesignPatterns.Behavioral.Strategy.Sample2
{
    public class PercentagePricingStrategy : IPricingStrategy
    {
        public long Calculate(IOrder order)
        {
            var amount = order.GetPrice();
            return PriceDiscounter.GetDiscountedAmount(amount, 10);
        }
    }
}
