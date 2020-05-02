namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// Classes implementing this interface either handle the request directly or forward it to the next handler(if any) on the chain.
    /// </summary>
    public abstract class Handler
    {
        private readonly Handler _succesor;

        public Handler()
        {
        }

        public Handler(Handler succesor)
        {
            _succesor = succesor;
        }

        public virtual void HandleRequest()
        {
            if(_succesor != null)
            {
                _succesor.HandleRequest();
            }
        }

        public bool CanHandleRequest()
        {
            return false;
        }
    }
}
