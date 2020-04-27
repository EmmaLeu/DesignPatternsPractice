namespace DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// Defines an abstract method for creation of <see cref="IProduct"/>
    /// </summary>
    public abstract class Creator
    {
        private IProduct _product;

        public abstract IProduct ProductFactory();

        public string Operation()
        {
            _product = ProductFactory();
            return _product.GetName();
        }
    }
}
