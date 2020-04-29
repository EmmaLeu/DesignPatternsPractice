namespace DesignPatterns.Structural.Decorator
{
    public class Decorator2 : Decorator
    {
        public Decorator2(IComponent component) : base(component)
        {
        }

        public override string Operation()
        {
            var result = base.Operation();
            return AddBehavior(result);
        }

        private string AddBehavior(string result)
        {
            return "2" + result + "2";
        }
    }
}
