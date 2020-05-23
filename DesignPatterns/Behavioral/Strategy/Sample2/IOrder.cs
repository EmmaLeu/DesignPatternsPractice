namespace DesignPatterns.Behavioral.Strategy.Sample2
{
    /// <summary>
    /// Interface to express prices in cents
    /// </summary>
    public interface IOrder
    {
        long GetPrice();

        long GetNetPrice();

        long GetNetPrice(IPricingStrategy strategy);

        void CreateOrderLine(IProduct product, int quantity);
    }
}
