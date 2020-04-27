namespace DesignPatterns.Creational.FactoryMethod
{
    public class CreatorB : Creator
    {
        public override IProduct ProductFactory()
        {
            return new ProductB();
        }
    }
}
