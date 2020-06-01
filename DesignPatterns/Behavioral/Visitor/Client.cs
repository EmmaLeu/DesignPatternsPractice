using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Visitor
{
    public class Client
    {
        private readonly List<IElement> _elements = new List<IElement> { new ElementA(), new ElementB() };
        private readonly IVisitor _visitor;

        public Client(IVisitor visitor)
        {
            _visitor = visitor;
        }

        public void Operation()
        {
            foreach(var element in _elements)
            {
                element.Accept(_visitor);
            }
        }
    }
}
