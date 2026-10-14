namespace SpecialFeatures.Model_Configuration
{
    using System;

    public interface IParser
    {
        void Clear();
        ExpTreeNode ParseExpression(string exp);
        int Priority(string Operator);
        bool RegisterToken(string Token, Token tk_type);
        string ReMakeExpression(ExpTreeNode Tree);
    }
}

