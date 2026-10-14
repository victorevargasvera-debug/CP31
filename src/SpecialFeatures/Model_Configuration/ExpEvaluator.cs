namespace SpecialFeatures.Model_Configuration
{
    using System;
    using System.Reflection;

    public class ExpEvaluator : IOperatorImp
    {
        private IParser a;
        private ExpTreeNode b;

        internal ExpEvaluator(IParser _parser);
        private bool a(ExpTreeNode A_0);
        internal bool Evaluate();
        internal bool SetExpression(string _exp);

        internal bool this[string sym] { set; }
    }
}

