namespace DesignPatterns.Behavioral.Interpreter.Sample2
{
    /// <summary>
    /// expression 'or' expression
    /// </summary>
    public class OrExpression : NonTerminalExpression
    {
        public override bool Evaluate(Context context)
        {
            var enumerator = GetEnumerator();
            while(enumerator.MoveNext())
            {
                if((enumerator.Current as Expression).Evaluate(context))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
