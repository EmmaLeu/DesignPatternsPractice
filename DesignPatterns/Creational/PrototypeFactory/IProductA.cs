namespace DesignPatterns.Creational.PrototypeFactory
{
    public interface IProductA
    {
        string GetName();

        IProductA Clone();
    }
}
