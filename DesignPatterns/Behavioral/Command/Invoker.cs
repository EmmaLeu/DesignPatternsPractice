namespace DesignPatterns.Behavioral.Command
{
    /// <summary>
    /// Delegates requests to <see cref="ICommand"/>
    /// </summary>
    public class Invoker
    {
        private readonly ICommand _command;

        public Invoker(ICommand command)
        {
            _command = command;
        }

        public void Operation()
        {
            _command.Execute();
        }
    }
}
