namespace DesignPatterns.Behavioral.Strategy.Sample1
{
    public class Context
    {
        private IStrategy _strategy;
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public string Operation()
        {
            return nameof(Context) + _strategy.Algorithm();
        }
    }
}
