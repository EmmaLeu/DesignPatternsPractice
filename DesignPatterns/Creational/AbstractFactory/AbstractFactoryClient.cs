using DesignPatterns.Creational.AbstractFactory;

namespace DesignPatterns
{
    /// <summary>
    /// Delegates creating ProductA and ProductB objects to factory object <see cref="AbstractFactory"/>
    /// </summary>
    public class AbstractFactoryClient
    {
        private readonly IProductA _productA;

        private readonly IProductB _productB;

        private readonly AbstractFactory _abstractFactory;

        public AbstractFactoryClient(AbstractFactory abstractFactory)
        {
            _abstractFactory = abstractFactory;
            _productA = _abstractFactory.CreateProductA();
            _productB = _abstractFactory.CreateProductB();
        }

        public string GetProductNames()
        {
            return _productA.GetName() + _productB.GetName();
        }
    }
}
