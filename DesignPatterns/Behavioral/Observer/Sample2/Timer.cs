namespace DesignPatterns.Behavioral.Observer.Sample2
{
    public class Timer : Subject
    {
        public int Hour { get; private set; }

        public int Minute { get; private set; }

        public int Second { get; private set; }

        public void Tick(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;

            Notify();
        }
    }
}
