using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Interpreter.Sample2
{
    public abstract class NonTerminalExpression : Expression
    {
        private readonly List<Expression> _expressions = new List<Expression>();

        public override abstract bool Evaluate(Context context);

        public override void Add(Expression e)
        {
            _expressions.Add(e); 
        }

        public override IEnumerator GetEnumerator()
        {
            return _expressions.GetEnumerator();
        }
    }
}
