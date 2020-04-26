namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// Implements the <see cref="ITarget"/> in terms of (inheriting) <see cref="Adaptee"/>
    /// The less flexible variant of <see cref="ObjectAdapter"/>
    /// </summary>
    public class ClassAdapter : Adaptee, ITarget
    {
        public string Operation()
        {
            return SpecificOperation();
        }
    }
}
