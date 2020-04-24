namespace DesignPatterns.Prototype
{
    /// <summary>
    /// Acts as a prototype for creating a copy of itself
    /// </summary>
    public class Product : IProduct, IPrototype
    {
        private readonly string _name;

        public Product(string name)
        {
            _name = name;
        }

        public Product(IProduct product)
        {
            _name = product.GetName();
        }

        public string GetName()
        {
            return _name;
        }

        public IProduct Clone()
        {
            return new Product(this);
        }

    }
}
