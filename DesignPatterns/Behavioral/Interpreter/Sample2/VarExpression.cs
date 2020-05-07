namespace DesignPatterns.Behavioral.Interpreter.Sample2
{
    /// <summary>
    ///  'x' | 'y' | 'z'
    /// </summary>
    public class VarExpression : Expression
    {
        public VarExpression(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public override bool Evaluate(Context context)
        {
            return context.GetVarExpression(Name);
        }
    }
}
