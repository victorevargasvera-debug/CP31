namespace SpecialFeatures.Flashport.FlashRadio
{
    using AcpCommonLib;
    using Motorola.Acp.PackUnpack.Ish.Layouts;
    using System;

    public class Option
    {
        private string a;
        private string b;
        private int c;
        private int d;
        private int e;
        private int[] f;
        private IAcpField g;
        private IntMask h;
        private FieldLayout i;
        private OptionGatingConstraint j;
        private OptionIDs k;

        internal Option(string name, string desc, int fcodePos, OptionIDs optionID);
        internal Option(string name, int dispOrder, IAcpField field, FieldLayout fldLayout, OptionIDs optionID);
        internal Option(string name, int dispOrder, IAcpField field, FieldLayout fldLayout, OptionGatingConstraint optionGate, OptionIDs optionID);
        internal Option(string name, int dispOrder, int bitsVal, IAcpField field, FieldLayout fldLayout, OptionIDs optionID);
        internal Option(string name, int dispOrder, int bitsVal, IAcpField field, FieldLayout fldLayout, OptionGatingConstraint optionGate, OptionIDs optionID);
        public override string ToString();

        public string Name { get; }

        public string Description { get; }

        internal int Position { get; }

        internal int BitsValue { get; }

        internal int DisplayOrder { get; }

        public IAcpField DbField { get; }

        internal int[] PositionArray { get; }

        internal IntMask Mask { get; }

        internal OptionGatingConstraint IsOptionUsed { get; set; }

        internal int BitOffset { get; }

        internal int ByteOffset { get; }

        public OptionIDs OptionID { get; set; }
    }
}

