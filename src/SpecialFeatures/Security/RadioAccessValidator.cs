namespace SpecialFeatures.Security
{
    using AcpASKLib;
    using Motorola.Common.Communication.CommonUtil;
    using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
    using SpecialFeatures.Comms;
    using System;
    using System.Collections.ObjectModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public static class RadioAccessValidator
    {
        private static bool a();
        private static string b();
        private static string c();
        public static bool CacheCodeplugSecurityFields(out bool wp, out bool askReq, out int ownerKeyType, out int ownerSysId, out int ownerWacnId, out ASKProgrammingHistoryInnerRecset askProgRecset, out int programmingPath);
        internal static bool CheckIfCustomerIDIsInACK(int customerID);
        internal static bool CheckIfIsACK();
        private static RadioSecurityData d();
        internal static bool FileCloneSerialNumberEditabilityCheck();
        internal static bool GetCodeplugASKRequiredFlag();
        internal static int GetCodeplugOwnerKeyType();
        internal static int GetCodeplugOwnerSystemID();
        internal static int GetCodeplugOwnerWACNID();
        internal static ProtectionOption GetCodeplugProtectionOption();
        internal static ProtectionOption GetProtectionOption(string modelNumber, string flashCode, bool fromCodeplug);
        internal static bool Is800MHzBandEnabled(string modelNumber, string flashCode);
        public static bool IsAstroMSOtarEnabled(string modelNumber, string flashCode);
        public static bool IsConvOnly(string modelNumber, string flashCode, bool fromCodeplug);
        internal static bool IsCpgConvOnly();
        public static bool IsCpgOwnerSystemIDValid(out string statusMsg);
        public static bool IsHardwareAskLoaded(int currentTrkSysId, ObservableCollection<SystemKeyData> loadedHardwareAdvancedKeys);
        public static bool RadioWriteSecurityCheck(COMMS_OP WriteType, RadioSecurityData radSecData, IshItemCollection progHistoryItems, Collection<TrkSysBandPlan> radioTrkShuffledBandPlans, out string stsMsg, bool writeProtectWriteProtectedRadio, bool otapBatchProgramming, bool updateWriteProtect);
        public static bool RestoreCachedCodeplugSecurityFields(bool wp, bool askReq, int ownerKeyType, int ownerSysId, int ownerWacnId, ASKProgrammingHistoryInnerRecset askProgRecset, int programmingPath);

        [CompilerGenerated]
        private sealed class <>c__DisplayClass0_0
        {
            public int currentTrkSysId;

            public <>c__DisplayClass0_0();
            internal bool <IsHardwareAskLoaded>b__0(SystemKeyData s);
        }
    }
}

