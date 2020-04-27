namespace DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// Provides an interface for creating objects or family of objects without specifying the concrete class.
    /// Common interface for creating a family of objects
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract IProductA CreateProductA();

        public abstract IProductB CreateProductB();
    }
}
