namespace DesignPatterns.Prototype
{
    /// <summary>
    /// Interface used to clone a <see cref="IProduct"/>
    /// </summary>
    public interface IPrototype
    {
        IProduct Clone();
    }
}
