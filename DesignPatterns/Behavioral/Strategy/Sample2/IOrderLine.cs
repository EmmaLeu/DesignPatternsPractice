namespace DesignPatterns.Behavioral.Strategy.Sample2
{
    public interface IOrderLine
    {
        IProduct Product { get; }

        long Quantity { get; }

        long Price { get; }
    }
}
