namespace DesignPatterns.Behavioral.Interpreter.Sample2
{
    public interface IProduct
    {
        void Operation();

        string Id { get; }

        string Group { get; }

        string Description { get; }

        long Price { get; }
    }
}
