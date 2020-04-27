namespace DesignPatterns.Creational.AbstractFactory
{
    public class Factory1 : AbstractFactory
    {
        public override IProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override IProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
