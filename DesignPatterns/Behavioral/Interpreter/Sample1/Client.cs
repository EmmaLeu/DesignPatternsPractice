namespace DesignPatterns.Behavioral.Interpreter.Sample1
{
    public class Client
    {
        public void Operation()
        {
            // Building an abstract syntax tree (AST)         
            AbstractExpression ntExpr2 = new NonTerminalExpression("ntExpr2");
            ntExpr2.Add(new TerminalExpression(" tExpr3"));
            ntExpr2.Add(new TerminalExpression(" tExpr4"));
            ntExpr2.Add(new TerminalExpression(" tExpr5"));
            AbstractExpression ntExpr1 = new NonTerminalExpression("ntExpr1");
            ntExpr1.Add(new TerminalExpression(" tExpr1"));
            ntExpr1.Add(ntExpr2);
            ntExpr1.Add(new TerminalExpression(" tExpr2"));
            Context context = new Context();

            // Interpreting the AST (walking the tree).
            ntExpr1.Interpret(context);
        }
    }
}
