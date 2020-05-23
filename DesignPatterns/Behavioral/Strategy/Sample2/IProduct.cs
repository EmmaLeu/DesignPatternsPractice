namespace DesignPatterns.Behavioral.Strategy.Sample2
{
    public interface IProduct
    {
        string Id { get; }

        string Group { get; }

        string Description { get; }

        long Price { get; }

        void Operation();
    }
}
