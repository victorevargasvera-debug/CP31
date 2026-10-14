namespace SpecialFeatures.Model_Configuration
{
    using System;
    using System.Reflection;

    public class ExpTreeNode
    {
        public const object INVALID = null;
        internal object _value;
        internal string _symbol;
        internal ExpTreeNode.NodeType _ndType;
        internal ExpTreeNode _left;
        internal ExpTreeNode _right;

        public ExpTreeNode();
        private void a(string A_0, bool A_1);
        internal bool ValidateExpTree();

        internal bool this[string sym] { set; }

        public enum NodeType
        {
            Literal,
            Symbol,
            Operator,
            Function,
            InValid
        }
    }
}

