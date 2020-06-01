namespace DesignPatterns.Behavioral.Visitor
{
    /// <summary>
    /// Interface for dispatching (delegating) client requests to a Visitor object
    /// </summary>
    public interface IElement
    {
        public void Accept(IVisitor visitor);   
    }
}
