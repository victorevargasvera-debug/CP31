namespace SpecialFeatures.Security
{
    using AcpASKLib;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class TrkSysID
    {
        private KeyType a;
        private int b;
        [CompilerGenerated]
        private bool? c;
        [CompilerGenerated]
        private bool d;
        [CompilerGenerated]
        private string e;

        internal TrkSysID(KeyType sysKeyType, int sysId, bool? askRequired, string systemName);

        internal KeyType SystemKeyType { get; }

        internal int ID { get; }

        internal bool? AskRequired { get; set; }

        internal bool UnlimitedAskRequired { get; set; }

        internal string SystemName { get; set; }
    }
}

