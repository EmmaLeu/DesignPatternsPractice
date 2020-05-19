using DesignPatterns.Behavioral.Mediator;
using Moq;
using NUnit.Framework;

namespace DesignPatternsTests.Behavioral
{
    public class MediatorTests
    {
        [Test]
        public void ClientOperation_Calls_Mediate()
        {
            var mediator = new Mock<IMediator>();
            var colleague1 = new Colleague1(mediator.Object);
            var colleague2 = new Colleague2(mediator.Object);
            var client = new Client(colleague1, colleague2);

            client.Example();

            mediator.Verify(a => a.Mediate(It.Is<Colleague>(c => c == colleague1)), Times.Once);
            mediator.Verify(a => a.Mediate(It.Is<Colleague>(c => c == colleague2)), Times.Once);
        }
    }
}
