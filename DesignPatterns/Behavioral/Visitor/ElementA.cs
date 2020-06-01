namespace DesignPatterns.Behavioral.Visitor
{
    public class ElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitElementA(this);
        }

        public string OperationA()
        {
            return nameof(ElementA);
        }
    }
}
