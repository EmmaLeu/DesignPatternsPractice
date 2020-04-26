namespace DesignPatterns.PrototypeFactory
{
    /// <summary>
    /// Delegates the creation of objects or families of objects to another class <see cref="PrototypeFactory"/>
    /// </summary>
    public class PrototypeFactoryClient
    {
        private readonly IProductA _productA;

        private readonly IProductB _productB;

        private readonly PrototypeFactory _prototypeFactory;

        public PrototypeFactoryClient(PrototypeFactory prototypeFactory)
        {
            _prototypeFactory = prototypeFactory;
            _productA = _prototypeFactory.CreateProductA();
            _productB = _prototypeFactory.CreateProductB();
        }

        public string GetProductNames()
        {
            return _productA.GetName() + _productB.GetName();
        }
    }
}
