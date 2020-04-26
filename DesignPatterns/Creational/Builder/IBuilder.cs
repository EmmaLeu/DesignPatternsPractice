namespace DesignPatterns.Builder
{
    /// <summary>
    /// Encapsulates the creation and assembling of a <see cref="ComplexObject"/>
    /// </summary>
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        ComplexObject GetResult();
    }
}
