namespace DesignPatterns.Behavioral.Strategy.Sample2
{
    public interface IPricingStrategy
    {
        long Calculate(IOrder order);
    }
}
