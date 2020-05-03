using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Interpreter.Sample1
{
    /// <summary>
    /// Directs interpretation to child expressions
    /// </summary>
    public class NonTerminalExpression : AbstractExpression
    {
        private List<AbstractExpression> _expressions = new List<AbstractExpression>();

        public NonTerminalExpression(string name) : base(name)
        {
        }

        public override void Interpret(Context context)
        {
            foreach(var expression in _expressions)
            {
                Console.WriteLine($"Interpreting : {expression.GetName()} ...");
                expression.Interpret(context);
                Console.WriteLine($" {expression.GetName()} finished");
            }
        }

        public override void Add(AbstractExpression abstractExpression)
        {
            _expressions.Add(abstractExpression);
        }
    }
}
