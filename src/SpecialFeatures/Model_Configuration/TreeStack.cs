namespace SpecialFeatures.Model_Configuration
{
    using System;

    public class TreeStack
    {
        private ExpTreeNode[] a;
        private int b;

        internal TreeStack(int size);
        internal void Clear();
        internal bool IsEmpty();
        internal ExpTreeNode Pop();
        internal void Push(ExpTreeNode f);

        public ExpTreeNode Top { get; set; }
    }
}

