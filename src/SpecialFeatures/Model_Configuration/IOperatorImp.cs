namespace SpecialFeatures.Model_Configuration
{
    using System;

    public abstract class IOperatorImp
    {
        protected IOperatorImp();
        public virtual bool ApplyOp(string Op, bool operand1, bool operand2);
    }
}

