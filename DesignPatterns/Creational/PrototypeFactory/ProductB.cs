namespace DesignPatterns.PrototypeFactory
{
    public class ProductB : IProductB
    {
        private readonly string _name;

        public ProductB(string name)
        {
            _name = name;
        }
        
        //copy constructor
        public ProductB(ProductB productB)
        {
            _name = productB.GetName();
        }

        public IProductB Clone()
        {
            return new ProductB(this);
        }

        public string GetName()
        {
            return _name;
        }
    }
}
