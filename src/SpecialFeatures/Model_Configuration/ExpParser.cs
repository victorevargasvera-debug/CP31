namespace SpecialFeatures.Model_Configuration
{
    using System;
    using System.Text.RegularExpressions;

    public class ExpParser : IParser
    {
        private Regex a;
        private Regex b;
        private Regex c;
        private Token d;
        private string e;
        private string f;
        private double g;
        private int h;
        private string i;
        private TreeStack j;
        private TreeStack k;

        public ExpParser();
        private void a();
        private bool a(string A_0);
        public void Clear();
        protected Token NextToken();
        public ExpTreeNode ParseExpression(string exp);
        public int Priority(string Operator);
        public bool RegisterToken(string Token, Token tk_type);
        public string ReMakeExpression(ExpTreeNode Tree);
    }
}

