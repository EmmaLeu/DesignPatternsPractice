using DesignPatterns.Behavioral.State;
using NUnit.Framework;

namespace DesignPatternsTests.Structural
{
    public class StateTests
    {
        [Test]
        public void Context_ChangesState()
        {
            var context = new Context(State1.Instance);

            var result = context.Operation();
            Assert.AreEqual(
                string.Format(Resources.ContextOperationFormat, nameof(Context), string.Format(Resources.StateOperationFormat, nameof(State1), nameof(State2))),
                result);

            result = context.Operation();
            Assert.AreEqual(
                string.Format(Resources.ContextOperationFormat, nameof(Context), string.Format(Resources.StateOperationFormat, nameof(State2), nameof(State1))),
                result);
        }
    }
}
