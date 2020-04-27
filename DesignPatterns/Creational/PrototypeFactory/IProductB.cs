namespace DesignPatterns.Creational.PrototypeFactory
{
    public interface IProductB
    {
        string GetName();

        IProductB Clone();
    }
}
