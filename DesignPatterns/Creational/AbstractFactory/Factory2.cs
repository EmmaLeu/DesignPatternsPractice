namespace DesignPatterns.AbstractFactory
{
    public class Factory2 : AbstractFactory
    {
        public override IProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override IProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
