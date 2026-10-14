namespace SpecialFeatures.Comms
{
    using Motorola.Common.Communication.CommonUtil;
    using Motorola.Common.Communication.Pba;
    using SpecialFeatures.Security;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public static class ParseDataHelper
    {
        internal const int TRUNKING_SYSTEM_COUNT_MSB_INDEX = 5;
        internal const int TRUNKING_SYSTEM_COUNT_LSB_INDEX = 6;
        internal const int TRUNKING_SYSTEM_NAME_SIZE_MSB_INDEX = 1;
        internal const int TRUNKING_SYSTEM_NAME_SIZE_LSB_INDEX = 2;
        internal const int TRUNKING_SYSTEM_NAME_STRING_START_INDEX = 0x13;
        internal const int TRUNKING_SYSTEM_ID_MSB_INDEX = 0x3b;
        internal const int TRUNKING_SYSTEM_ID_LSB_INDEX = 60;
        internal const int TRUNKING_SYSTEM_ASK_REQUIRED_BYTE_INDEX = 130;
        internal const int TRUNKING_SYSTEM_UNIT_ID_MSB_INDEX = 0x3f;
        internal const int TRUNKING_SYSTEM_UNIT_ID_BYTE_3_INDEX = 0x40;
        internal const int TRUNKING_SYSTEM_UNIT_ID_BYTE_2_INDEX = 0x41;
        internal const int TRUNKING_SYSTEM_UNIT_ID_LSB_INDEX = 0x42;
        internal const int TRUNKING_SYSTEM_SYSTEM_TYPE_BYTE_INDEX = 1;

        internal static IshItem GetBlockIshItem(PbaObject pba, ushort itemID);
        internal static string getCodeplugFlashCode();
        internal static byte[] GetFDB(PbaObject pba);
        internal static bool GetIshItemPCICapable(PbaObject pba, int nOffset, int nValue);
        internal static IshItemCollection GetRadioASKProgrammingHistoryList(PbaObject pba);
        internal static string GetRadioFlashcodeFromFBD(byte[] featDescBlk);
        internal static void GetRadioSecurityConfigurationData(string curRadioCpgVersion, ProtectionOption opt, out int ownerAdvKeyType, out int ownerSysId, out int ownerWacnId, out bool bAskReq, out bool bWriteProtected, PbaObject pba);
        internal static RadioSecurityData GetRadioSecurityData(RadioParams curRadioParms, PbaObject pba);
        internal static Collection<TrkSysBandPlan> GetRadioTrkSystemShuffledBandPlans(PbaObject pba);
        internal static Dictionary<string, bool> IsRadioInhibitedTrunking(PbaObject pba);
        internal static Dictionary<string, bool> IsRadioKilled(PbaObject pba);
        public static string RadioSNToString(string radSN);
        internal static Dictionary<string, int> ReadAstroOtarRadioIds(PbaObject pba);
        internal static string ReadBluetoothFriendlyName(PbaObject pba);
        internal static Dictionary<string, int[]> ReadConvSysIds(PbaObject pba);
        internal static Dictionary<string, int> ReadCustomerID(PbaObject pba);
        internal static DataProfIP[] ReadDataProfIPaddr(PbaObject pba);
        internal static string ReadEncryptPassword(PbaObject pba);
        public static bool ReadEncryptPasswordFlag(PbaObject pba);
        internal static int ReadProgrammingPathValue(PbaObject pba);
        internal static string[] ReadRadioTrkSysNames(IshItemCollection ishItemCollection);
        internal static void ReadRadioTrkSystemNamesAndIds(IshItemCollection ishItemCollection, out Dictionary<string, int> radioTrkSysNamesAndIdsWithAskReqOn, out Dictionary<string, int> radioTrkSysNamesAndIdsWithAskReqOff);
        internal static Dictionary<string, int[]> ReadRadioTrkSystemNamesTypesAndUnitIds(IshItemCollection ishItemCollection);
        internal static string[] ReadSoftId(PbaObject pba);
        internal static int ReadTxPowerLevelsCFGType(PbaObject pba);
        internal static IshItemCollection ReplaceSecurityPartition(IshItemCollection ishItems, DataPartition oldSecurityPartition);
        internal static IshItemCollection UpdateBlockIshItem(IshItemCollection ishItems, IshItem blockItem, byte partition, ushort blockType);

        [CompilerGenerated]
        private sealed class <>c__DisplayClass38_0
        {
            public IshItemCollection ishItems;

            public <>c__DisplayClass38_0();
            internal void <ReplaceSecurityPartition>b__0(IshHeader s);
        }
    }
}

