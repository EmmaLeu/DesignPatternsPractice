using DesignPatterns.Behavioral.Strategy.Sample1;
using NUnit.Framework;

namespace DesignPatternsTests.Behavioral
{
    public class StrategyTests
    {
        [Test]
        public void Sample1_ContextSwitches_Strategies()
        {
            var context = new Context();

            context.SetStrategy(new Strategy1());
            var result = context.Operation();

            Assert.AreEqual(nameof(Context) + 1, result);

            context.SetStrategy(new Strategy2());
            result = context.Operation();

            Assert.AreEqual(nameof(Context) + 2, result);
        }
    }
}
