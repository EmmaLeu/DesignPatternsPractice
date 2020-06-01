namespace DesignPatterns.Behavioral.Visitor
{
    /// <summary>
    /// For all supported <see cref="IElement"/> classes, defines a common interface for visiting each <see cref="IElement"/> class
    /// </summary>
    public interface IVisitor
    {
        public void VisitElementA(ElementA element);

        public void VisitElementB(ElementB element);
    }
}
