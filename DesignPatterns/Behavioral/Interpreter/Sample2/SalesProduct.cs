using System;

namespace DesignPatterns.Behavioral.Interpreter.Sample2
{
    public class SalesProduct : IProduct
    {
        public SalesProduct(string id, string group, string description, long price)
        {
            Id = id;
            Group = group;
            Price = price;
            Description = description;
        }

        public string Description { get; }

        public string Group { get; }

        public string Id { get; }

        public long Price { get; }

        public void Operation()
        {
            Console.WriteLine($"{nameof(SalesProduct)} performing some operation");
        }
    }
}
