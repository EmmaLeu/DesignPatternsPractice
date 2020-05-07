using System.Collections;

namespace DesignPatterns.Behavioral.Interpreter.Sample2
{
    /// <summary>
    /// andExp | orExp | notExp | varExp | '(' expression ')'
    /// </summary>
    public abstract class Expression : IEnumerable
    {
        public abstract bool Evaluate(Context context);

        public virtual void Add(Expression e)
        {
        }

        public virtual IEnumerator GetEnumerator()
        {
            yield break;
        }
    }
}

