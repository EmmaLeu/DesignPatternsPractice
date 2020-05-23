namespace DesignPatterns.Behavioral.Strategy.Sample2
{
    public static class PriceDiscounter
    {
        public static long GetDiscountedAmount(long amount, int percentage)
        {
            return amount - amount / 100 * percentage;
        }
    }
}
