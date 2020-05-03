using DesignPatterns.Behavioral.Command;
using Moq;
using NUnit.Framework;

namespace DesignPatternsTests.Behavioral
{
    public class CommandTests
    {
        [Test]
        public void Invoker_RedirectsRequests_ToCommand()
        {
            var command = new Mock<ICommand>();
            var invoker = new Invoker(command.Object);

            invoker.Operation();

            command.Verify(a => a.Execute(), Times.Once);
        }

        [Test]
        public void Command_CallsAction_OnReceiver()
        {
            var receiver = new Mock<IReceiver>();
            var command = new Command(receiver.Object);

             command.Execute();

            receiver.Verify(a => a.Action(), Times.Once);
        }
    }
}
