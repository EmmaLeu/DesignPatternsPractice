using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// Forwards requests to its succesor
    /// </summary>
    public class Receiver2 : Handler
    {
        public Receiver2(Handler succesor) : base(succesor)
        {
        }

        public override void HandleRequest()
        {
            if (CanHandleRequest())
            {
                Console.WriteLine("Can handle request");
            }
            else
            {
                base.HandleRequest();
            }
        }
    }
}
