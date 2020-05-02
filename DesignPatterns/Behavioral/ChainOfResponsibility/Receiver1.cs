using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// Forwards requests to its succesor
    /// </summary>
    public class Receiver1 : Handler
    {
        public Receiver1(Handler succesor) : base(succesor)
        {
        }

        public override void HandleRequest()
        {
            if(CanHandleRequest())
            {
                //handling request
            }
            else
            {
                //forwarding request
                base.HandleRequest();
            }
        }
    }
}
