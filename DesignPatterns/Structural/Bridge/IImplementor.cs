namespace DesignPatterns.Structural.Bridge
{
    /// <summary>
    /// Usually defines primitive operations, unlike <see cref="IAbstraction"/> which has higher level ops
    /// </summary>
    public interface IImplementor
    {
        string OperationImpl();
    }
}
