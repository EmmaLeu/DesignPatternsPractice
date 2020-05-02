using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// Handles request
    /// </summary>
    public class Receiver3 : Handler
    {
        public override void HandleRequest()
        {
            //handling request unconditionally
        }
    }
}
