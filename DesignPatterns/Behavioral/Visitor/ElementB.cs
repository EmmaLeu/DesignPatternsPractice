namespace DesignPatterns.Behavioral.Visitor
{
    public class ElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitElementB(this);
        }

        public string OperationB()
        {
            return nameof(ElementB);
        }
    }
}
