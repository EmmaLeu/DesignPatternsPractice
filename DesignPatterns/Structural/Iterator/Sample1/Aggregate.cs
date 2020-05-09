using System;

namespace DesignPatterns.Structural.Iterator.Sample1
{
    /// <summary>
    /// Implement CreateIterator() by returning an instance of the corresponding iterator class 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Aggregate<T> : IAggregate<T>
    {
        private readonly int _size;
        private readonly T[] _elementData;
        private int _index;

        public Aggregate(int size)
        {
            if(size < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size));
            }

            _size = size;
            _elementData = new T[_size];
        }

        public bool Add(T element)
        {
            if(_index < _size)
            {
                _elementData[_index++] = element;
                return true;
            }

            return false;
        }

        public IIterator<T> CreateIterator()
        {
            return new Iterator<T>(this);
        }
        
        public int GetSize()
        {
            return _size;
        }

        // Implementing iterator as inner class
        private class Iterator<T> : IIterator<T>
        {
            private int _cursor;

            private readonly Aggregate<T> @this;

            public Iterator(Aggregate<T> aggregate)
            {
                @this = aggregate;
            }

            public T Next()
            {
                if(_cursor >= @this._size)
                {
                    throw new IndexOutOfRangeException();
                }

                return @this._elementData[_cursor++];
            }

            public bool HasNext()
            {
                return _cursor < @this._size;
            }
        }
    }
}
