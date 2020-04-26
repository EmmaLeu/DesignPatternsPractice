namespace DesignPatterns.Builder
{
    public class ProductA : IProductA
    {
        public string GetName()
        {
            return nameof(ProductA);
        }
    }
}
