using DesignPatterns.Structural.Bridge;

namespace DesignPatternsTests.Structural
{
    internal class Implementation : IImplementor
    {
        public string OperationImpl()
        {
            return nameof(Implementation);
        }
    }
}