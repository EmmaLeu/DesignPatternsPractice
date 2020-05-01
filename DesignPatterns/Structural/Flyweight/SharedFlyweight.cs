namespace DesignPatterns.Structural.Flyweight
{
    public class SharedFlyweight : IFlyweight
    {
        private readonly string _intrinsicState;

        public SharedFlyweight(string intrinsicState)
        {
            _intrinsicState = intrinsicState;
        }

        public string Operation(int extrinsicState)
        {
            return string.Format(Resources.SharedFlyweightOperationMessage, extrinsicState, _intrinsicState);
        }
    }
}
