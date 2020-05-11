namespace DesignPatterns.Behavioral.Iterator.Sample1
{
    /// <summary>
    /// Interface for creating an <see cref="IIterator{T}"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAggregate<T>
    {     
        IIterator<T> CreateIterator();

        bool Add(T element);
    }
}
