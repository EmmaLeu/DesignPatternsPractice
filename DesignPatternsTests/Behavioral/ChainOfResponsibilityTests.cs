using DesignPatterns.Behavioral.ChainOfResponsibility;
using Moq;
using NUnit.Framework;

namespace DesignPatternsTests.Behavioral
{
    public class ChainOfResponsibilityTests
    {
        [Test]
        public void Sender_RedirectsRequests_ToHanlder()
        {
            var handler = new Mock<Handler>();
            var sender = new Sender(handler.Object);

            sender.Request();

            handler.Verify(a => a.HandleRequest(), Times.Once);
        }

        [Test]
        public void Receiver_Delegates_ToSuccessors()
        {
            var receiver3 = new Mock<Handler>()
            {
                CallBase = true
            };
            var receiver2 = new Mock<Handler>(receiver3.Object)
            {
                CallBase = true
            };
            var receiver1 = new Receiver1(receiver2.Object);

            receiver1.HandleRequest();

            receiver2.Verify(a => a.HandleRequest(), Times.Once);
            receiver3.Verify(a => a.HandleRequest(), Times.Once);
        }
    }
}
