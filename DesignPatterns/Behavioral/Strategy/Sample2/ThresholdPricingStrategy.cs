namespace DesignPatterns.Behavioral.Strategy.Sample2
{
    public class ThresholdPricingStrategy : IPricingStrategy
    {
        private const long _threshold = 200;
        private const short _percentageLow = 10;
        private const short _percentageHigh = 20;

        public long Calculate(IOrder order)
        {
            var amount = order.GetPrice();
            if(amount < _threshold)
            {
                return PriceDiscounter.GetDiscountedAmount(amount, _percentageLow);
            }
            else
            {
                return PriceDiscounter.GetDiscountedAmount(amount, _percentageHigh);
            }
        }
    }
}
