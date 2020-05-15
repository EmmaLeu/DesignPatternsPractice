namespace DesignPatterns.Behavioral.Observer.Sample1
{
    /// <summary>
    /// Object dependent of <see cref="Subject1"/> (must keept its state in sync with subject)
    /// </summary>
    public class Observer2 : IObserver
    {
        private readonly Subject1 _subject;

        public Observer2(Subject1 subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        public void Update()
        {
            State = _subject.State;
        }

        public int State { get; private set; }
    }
}
