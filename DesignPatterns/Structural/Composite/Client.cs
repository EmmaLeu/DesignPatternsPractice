namespace DesignPatterns.Structural.Composite
{
    public class Client
    {
        public Component BuildTree()
        {
            var composite2 = new Composite("composite2");
            composite2.Add(new Leaf("leaf3"));
            composite2.Add(new Leaf("leaf4"));
            composite2.Add(new Leaf("leaf5"));
            var composite1 = new Composite("composite1");
            composite1.Add(new Leaf("leaf1"));
            composite1.Add(composite2);
            composite1.Add(new Leaf("leaf2"));
            return composite1;
        }
    }
}
