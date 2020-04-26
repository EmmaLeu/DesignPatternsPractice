namespace DesignPatterns.PrototypeFactory
{
    public interface IProductB
    {
        string GetName();

        IProductB Clone();
    }
}
