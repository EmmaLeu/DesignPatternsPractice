namespace DesignPatterns.Structural.Composite
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override string Operation()
        {
            return GetName();
        }
    }
}
