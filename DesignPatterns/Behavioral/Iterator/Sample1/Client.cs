namespace DesignPatterns.Behavioral.Iterator.Sample1
{
    public class Client
    {
        private readonly Aggregate<string> _aggregate;

        public Client(int size)
        {
            _aggregate = new Aggregate<string>(size);
            AddElements(size);
        }

        public string GetElementNames()
        {
            var iterator = _aggregate.CreateIterator();
            var names = string.Empty;

            while(iterator.HasNext())
            {
                names += iterator.Next();
            }

            return names;
        }

        private void AddElements(int size)
        {
            for(var index = 0; index < size; index++)
            {
                _aggregate.Add($"element{index}");
            }
        }
    }
}
