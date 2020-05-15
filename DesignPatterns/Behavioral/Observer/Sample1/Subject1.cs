namespace DesignPatterns.Behavioral.Observer.Sample1
{
    /// <summary>
    /// Stores state that <see cref="IObserver"/>s depend on
    /// </summary>
    public class Subject1 : Subject
    {
        private int _state;

        public int State
        {
            get
            {
                return _state;
            }
            set
            {
                if(value != _state)
                {
                    _state = value;
                    Notify();
                }
            }
        }
    }
}
