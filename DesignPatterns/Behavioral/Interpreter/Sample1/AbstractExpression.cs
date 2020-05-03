namespace DesignPatterns.Behavioral.Interpreter.Sample1
{
    /// <summary>
    /// Defines a common interface for interpreting terminal expressions (tExpr) and nonterminal expressions (ntExpr) of an abstract syntax tree
    /// defining sentences in the language
    /// </summary>
    public abstract class AbstractExpression
    {
        private readonly string _name;

        public AbstractExpression(string name)
        {
            _name = name;
        }

        public abstract void Interpret(Context context);

        public string GetName() => _name;

        public virtual void Add(AbstractExpression abstractExpression)
        {
        }
    }
}
