using System;

namespace DesignPatterns.Behavioral.Strategy.Sample2
{
    public class SalesProduct : IProduct
    {
        public SalesProduct(string id, string group, string description, long price)
        {
            Id = id;
            Group = group;
            Description = description;
            Price = price;
        }

        public string Id { get; }

        public string Group { get; }

        public string Description { get; }

        public long Price { get; }

        public void Operation()
        {
            Console.WriteLine("Performing an operation...");
        }
    }
}
