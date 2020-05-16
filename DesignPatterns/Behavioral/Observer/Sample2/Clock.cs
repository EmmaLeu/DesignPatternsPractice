using System;

namespace DesignPatterns.Behavioral.Observer.Sample2
{
    public class Clock : IObserver
    {
        private readonly Timer _subject;

        public Clock(Timer subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        public void Update(Subject subject)
        {
            if(subject == _subject)
            {
                Console.WriteLine($"{nameof(Clock)} synchronized to: {_subject.Hour}:{_subject.Minute}:{_subject.Second}");
            }
        }
    }
}
