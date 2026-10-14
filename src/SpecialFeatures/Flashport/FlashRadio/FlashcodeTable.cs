namespace SpecialFeatures.Flashport.FlashRadio
{
    using AcpCommonLib;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class FlashcodeTable : IDisposable
    {
        private Flashcode a;
        private bool b;
        private bool c;
        private bool d;
        private bool e;
        private bool f;
        private string g;

        public FlashcodeTable();
        internal FlashcodeTable(bool ordered);
        public FlashcodeTable(bool isPortable, bool ordered);
        private bool a();
        internal bool AddOrDeleteHoptToCpg(Option opt, bool add);
        internal bool AddOrDeleteHoptToCpg(string name, bool add);
        private bool b();
        private bool c();
        internal void Clear();
        internal void Close();
        private bool d();
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        internal int GetFieldValue(IAcpField acpField);
        public string GetOptionsInOffset(int bytePos, int bitPos);
        public void InitTable(bool codeplugOpen, string modelNumber, bool forComparedCodeplug);
        public bool IsOptionEnabledInFlashcode(Option opt, string flashcode);
        internal bool IsOptionEnabledInFlashcode(string name, string flashcode, ref bool optionFound);
        public void SetFieldValue(IAcpField field, int fldValue);

        public Flashcode FLASHcode { get; }

        [Serializable, CompilerGenerated]
        private sealed class <>c
        {
            public static readonly FlashcodeTable.<>c <>9;
            public static OptionGatingConstraint <>9__12_0;
            public static OptionGatingConstraint <>9__12_1;

            static <>c();
            public <>c();
            internal bool <InitTable>b__12_0();
            internal bool <InitTable>b__12_1();
        }
    }
}

