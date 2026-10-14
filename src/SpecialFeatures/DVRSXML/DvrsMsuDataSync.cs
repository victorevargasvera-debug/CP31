namespace SpecialFeatures.DVRSXML
{
    using ConstraintHelper;
    using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
    using System;
    using System.Runtime.InteropServices;
    using System.Xml;

    public class DvrsMsuDataSync
    {
        private static string[] a;
        private XmlDocument b;
        private bool c;

        static DvrsMsuDataSync();
        public DvrsMsuDataSync();
        private UtilityMack.FrequencyBand a(Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem A_0);
        private UtilityMack.FrequencyBand a(int A_0);
        private bool a(string A_0);
        private UtilityMack.FrequencyBand a(int A_0, int A_1);
        private XmlElement a(XmlDocument A_0, DvrsElementItem A_1);
        internal DvrsElementItem BuildDvrsExportData();
        public string BuildFileName(string radioSerialNumber);
        public uint CalculateHashCode();
        internal string CovertChannelType(int value);
        internal string CovertDispMenuLanguage(int value);
        internal string CovertProtocolType(int value);
        internal string CovertRxVoiceSignalType(int value);
        internal string CovertSignalingSignalingType(int value);
        internal string CovertTalkgroup(int value);
        internal string CovertTransmitPowerLevelsBandSplitOverride(int value);
        internal string CovertTxVoiceSignalType(int value);
        public bool ExportToXmlDoc(string xmlFullPath);
    }
}

