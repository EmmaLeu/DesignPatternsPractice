namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// Sends a request to a chain of handlers
    /// </summary>
    public class Sender
    {
        private readonly Handler _requestHandler;

        public Sender(Handler handler)
        {
            _requestHandler = handler;
        }

        public void Request()
        {
            _requestHandler.HandleRequest();
        }
    }
}
