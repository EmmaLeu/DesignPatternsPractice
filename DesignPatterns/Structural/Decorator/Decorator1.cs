namespace DesignPatterns.Structural.Decorator
{
    public class Decorator1 : Decorator
    {
        public Decorator1(IComponent component) : base(component)
        {
        }

        public override string Operation()
        {
            var result = base.Operation();
            return AddBehavior(result);
        }

        private string AddBehavior(string result)
        {
            return "1" + result + "1";
        }
    }
}
