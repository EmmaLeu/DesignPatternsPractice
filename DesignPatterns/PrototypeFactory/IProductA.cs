namespace DesignPatterns.PrototypeFactory
{
    public interface IProductA
    {
        string GetName();

        IProductA Clone();
    }
}
