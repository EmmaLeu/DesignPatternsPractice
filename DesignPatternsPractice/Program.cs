using DesignPatterns.Behavioral.Interpreter.Sample1;
using System;

namespace DesignPatternsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interpreter
            var client = new Client();
            client.Operation();
        }
    }
}
