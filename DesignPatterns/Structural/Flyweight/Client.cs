namespace DesignPatterns.Structural.Flyweight
{
    /// <summary>
    /// Needs flyweight objects. Passes extrinsic state to objects operations
    /// </summary>
    public class Client
    {
        public int Operation()
        {
            IFlyweight flyweight;
            var flyweightFactory = FlyweightFactory.Instance;

            flyweight = flyweightFactory.GetFlyweight("A");
            flyweight.Operation(100);

            flyweight = flyweightFactory.GetFlyweight("A");
            flyweight.Operation(200);

            return flyweightFactory.GetSize();
        }
    }
}
