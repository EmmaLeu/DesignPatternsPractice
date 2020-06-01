using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Visitor;
using System;
using Sample1 = DesignPatterns.Behavioral.Interpreter.Sample1;
using Sample2 = DesignPatterns.Behavioral.Interpreter.Sample2;

namespace DesignPatternsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Interpreter***\n");
            //Interpreter
            var interpreterClient1 = new Sample1.Client();
            interpreterClient1.Operation();

            var interpreterClient2 = new Sample2.Client();
            interpreterClient2.SearchProducts();

            Console.WriteLine("\n***Memento***\n");
            //Memento
            var caretaker = new Caretaker();
            caretaker.Test();

            Console.WriteLine("\n***Visitor***\n");
            var visitorClient = new Client(new Visitor());
            visitorClient.Operation();
        }
    }
}
