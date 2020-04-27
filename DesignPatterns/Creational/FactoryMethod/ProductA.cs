namespace DesignPatterns.Creational.FactoryMethod
{
    public class ProductA : IProduct
    {
        public string GetName()
        {
            return nameof(ProductA);
        }
    }
}
