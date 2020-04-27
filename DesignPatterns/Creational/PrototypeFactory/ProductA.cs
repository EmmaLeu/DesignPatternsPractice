namespace DesignPatterns.Creational.PrototypeFactory
{
    public class ProductA : IProductA
    {
        private readonly string _name;

        public ProductA(string name)
        {
            _name = name;
        }

        //copy constructor
        public ProductA(ProductA productA)
        {
            _name = productA.GetName();
        }

        public IProductA Clone()
        {
            return new ProductA(this);
        }

        public string GetName()
        {
            return _name;
        }
    }
}
