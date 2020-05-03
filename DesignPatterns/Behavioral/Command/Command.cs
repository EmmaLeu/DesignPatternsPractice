namespace DesignPatterns.Behavioral.Command
{
    public class Command : ICommand
    {
        private readonly IReceiver _receiver;

        public Command(IReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            //do some pre-processing here
            _receiver.Action();
        }
    }
}
