namespace DesignPatterns.Structural.Composite
{
    /// <summary>
    /// Common interface defining operations for <see cref="Leaf"/> and <see cref="Composite"/>
    /// </summary>
    public abstract class Component
    {
        private readonly string _name;

        public Component(string name)
        {
            _name = name;
        }

        public abstract string Operation();

        public string GetName()
        {
            return _name;
        }

        public virtual void Add(Component child)
        {
            return;
        }
    }
}
