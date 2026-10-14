namespace SpecialFeatures.Security
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class RadioSecurityData
    {
        private ProtectionOption a;
        private bool b;
        private int c;
        private int d;
        private int e;
        private bool f;
        private bool g;
        internal KeyValuePair<string, int> IdAndNameOfTrkSysThatWillBeOverwritten;
        [CompilerGenerated]
        private Dictionary<string, int> h;
        [CompilerGenerated]
        private Dictionary<string, int> i;

        public RadioSecurityData(ProtectionOption protectionOpt, int advKeyType, int ownerSystemId, int ownerWacnId, bool bASKRequired, bool bWriteProtected, bool bConvnOnly, Dictionary<string, int> radioTrkSysNamesAndIdsWithAskReqOn, Dictionary<string, int> radioTrkSysNamesAndIdsWithAskReqOff);

        internal ProtectionOption ProtectionOptn { get; }

        internal bool ASKRequired { get; }

        internal int OwnerAdvancedKeyType { get; }

        internal int OwnerSystemID { get; }

        internal int OwnerWACNID { get; }

        internal bool WriteProtected { get; }

        internal bool IsConventionalOnly { get; }

        internal Dictionary<string, int> RadioTrkSystemsWithAskRequiredOn { get; set; }

        internal Dictionary<string, int> RadioTrkSystemsWithAskRequiredOff { get; set; }
    }
}

