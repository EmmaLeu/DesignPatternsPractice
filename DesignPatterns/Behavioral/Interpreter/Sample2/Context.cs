using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Interpreter.Sample2
{
    public class Context
    {
        private readonly Dictionary<string, bool> _varExpressionMap = new Dictionary<string, bool>();

        public void SetVarExpression(VarExpression var, bool value)
        {
            _varExpressionMap[var.Name] = value;
        }

        public bool GetVarExpression(string name)
        {
            return _varExpressionMap[name];
        }
    }
}
