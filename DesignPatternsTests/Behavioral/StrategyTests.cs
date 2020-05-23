using DesignPatterns.Behavioral.Strategy.Sample1;
using DesignPatterns.Behavioral.Strategy.Sample2;
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

        [Test]
        public void Sample2_GetsPrices_AccordingToStrategy()
        {
            var order = new SalesOrder(new PercentagePricingStrategy());
            var productA = new SalesProduct("A", "01", "ProductA", 100);
            var productB = new SalesProduct("B", "01", "ProductB", 200);
            order.CreateOrderLine(productA, 1);
            order.CreateOrderLine(productB, 1);

            var grossPrice = order.GetPrice();
            Assert.AreEqual(300, grossPrice);

            var netPrice = order.GetNetPrice(); //default strategy is being applied
            Assert.AreEqual(270, netPrice);

            var netPriceWithThreshold = order.GetNetPrice(new ThresholdPricingStrategy());
            Assert.AreEqual(240, netPriceWithThreshold);
        }
    }
}
