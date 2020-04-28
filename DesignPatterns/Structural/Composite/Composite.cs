using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    /// <summary>
    /// Can be seen as a subtree.
    /// </summary>
    public class Composite : Component
    {
        private readonly ICollection<Component> _children = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public override string Operation()
        {
            var str = GetName();
            foreach(var child in _children)
            {
                str += " " + child.Operation();
            }

            return str;
        }

        public override void Add(Component child)
        {
            _children.Add(child);
        }
    }
}
