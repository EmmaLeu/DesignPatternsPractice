namespace DesignPatterns.Behavioral.Iterator.Sample1
{
    /// <summary>
    /// Interface for accessing and iterating over aggregated objects
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IIterator<T>
    {
        bool HasNext();

        T Next();
    }
}
