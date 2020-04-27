namespace DesignPatterns.Creational.PrototypeFactory
{
    /// <summary>
    /// Provides methods for creating prototypes of objects <see cref="IProductA"/> <see cref="IProductB"/> without specifying the concrete class.
    /// </summary>
    public class PrototypeFactory
    {
        private readonly IProductA _productA;

        private readonly IProductB _productB;

        public PrototypeFactory(IProductA productA, IProductB productB)
        {
            _productA = productA;
            _productB = productB;
        }

        public IProductA CreateProductA()
        {
            return _productA.Clone();
        }

        public IProductB CreateProductB()
        {
            return _productB.Clone();
        }
    }
}
