namespace DesignPatterns.Structural.Bridge
{
    public class Implementor : IImplementor
    {
        public string OperationImpl()
        {
            return nameof(Implementor);
        }
    }
}
