namespace DesignPatterns.Behavioral.Interpreter.Sample1
{
    /// <summary>
    /// Implements direct interpretation for terminal expressions
    /// </summary>
    public class TerminalExpression : AbstractExpression
    {
        public TerminalExpression(string name) : base(name)
        {
        }

        public override void Interpret(Context context)
        {
            //interpret
        }
    }
}
