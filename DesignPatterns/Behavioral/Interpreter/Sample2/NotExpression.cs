namespace DesignPatterns.Behavioral.Interpreter.Sample2
{
    /// <summary>
    /// 'not' expression
    /// </summary>
    public class NotExpression : NonTerminalExpression
    {
        public override bool Evaluate(Context context)
        {
            var enumerator = GetEnumerator();

            while(enumerator.MoveNext())
            {
                if((enumerator.Current as Expression).Evaluate(context))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
