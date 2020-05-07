using Sample1 = DesignPatterns.Behavioral.Interpreter.Sample1;
using Sample2 = DesignPatterns.Behavioral.Interpreter.Sample2;

namespace DesignPatternsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interpreter
            var interpreterClient1 = new Sample1.Client();
            interpreterClient1.Operation();

            var interpreterClient2 = new Sample2.Client();
            interpreterClient2.SearchProducts();
        }
    }
}
