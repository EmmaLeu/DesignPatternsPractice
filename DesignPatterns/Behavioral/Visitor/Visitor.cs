using System;

namespace DesignPatterns.Behavioral.Visitor
{
    public class Visitor : IVisitor
    {
        public void VisitElementA(ElementA element)
        {
            Console.WriteLine($"Visiting {nameof(ElementA)}: {element.OperationA()}");
        }

        public void VisitElementB(ElementB element)
        {
            Console.WriteLine($"Visiting {nameof(ElementB)}: {element.OperationB()}");
        }
    }
}
