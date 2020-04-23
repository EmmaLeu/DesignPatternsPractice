namespace DesignPatterns.FactoryMethod
{
    public class ProductB : IProduct
    {
        public string GetName()
        {
            return nameof(ProductB);
        }
    }
}
