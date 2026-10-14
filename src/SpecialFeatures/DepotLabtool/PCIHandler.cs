namespace SpecialFeatures.DepotLabtool
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    internal class PCIHandler
    {
        private const string a = "EMG_RVT";
        private const string b = "EMG_BEACON_ROUTING";
        private const string c = "SOURCE_PCI_EXPANDED_MDC_E_F";
        private const string d = "SOURCE_PCI_DISABLE_EMERGENCY_CALL_INDICATIONS_CAPABLE";
        private const string e = "BASIC_CONTROL_HEAD";
        private const string f = "MAN_DOWN_EMER_PRF_CFG";
        private const string g = "EMER_TONE_CFG";
        private const string h = "SOURCE_PCI_PASS_ALARM_FILTER_CAPABLE";
        private const string i = "HOT_MIC";
        private const string j = "AUDIBLE_EMERGENCY_BEACON_FOR_MOBILE";
        private const string k = "AUDIO_ENH";
        private const string l = "STRING_PCI_MOSCAD3000_ENHANCE";
        private const string m = "STRING_PCI_PERSONNEL_ACCOUNTABILITY_ALERT_CAPABILITY";
        private const string n = "STRING_PCI_USER_SELECTABLE_PL_ENHANCEMENT";
        private const string o = "STRING_PCI_CONSOLIDATED_ACTIONS_ENHANCEMENT";
        private const string p = "STRING_PCI_LIMITED_ISSI_DVRS_OPERATION_CAPABLE";
        private const string q = "STRING_PCI_ACTIVE_MIC_FOR_PTT";
        private const string r = "STRING_PCI_APX_SINGLETONE_CAPABLE";
        private const string s = "STRING_PCI_ENHANCED_ARS";
        private const string t = "STRING_PCI_EMERGENCY_CALL_ONLY_WITH_HOT_MIC_CAPABLE";
        private const string u = "STRING_PCI_ZONE_CLONE_CAPABLE";
        private const string v = "STRING_PCI_EMERGENCY_CALL_TERMINATION";
        private const string w = "STRING_PCI_IPS_CAPABLE";
        private const string x = "STRING_PCI_DISABLE_WIND_NOISE_REDUCTION_LEVEL_FOR_ACCESSORIES";
        private const string y = "STRING_PCI_MARVELL_DNP";
        private const string z = "SOURCE_PCI_RADIOLOCK_EXTENSION_CAPABLE";
        private const string aa = "STRING_PCI_EXTENDED_PL_TONE_SET";
        private const string ab = "STRING_PCI_UCL_CONTACTS_LIMITATION_ENHANCEMENT";
        private const string ac = "STRING_PCI_ALLOW_PSU_SECURE";
        private const string ad = "STRING_PCI_DVRS_RANGE_EXT";
        private const string ae = "STRING_PCI_INDIRECT_PTT_AUDIO_ROUTING_PCI";
        private const string af = "PCI_ADP_FLASHCODE_GATING";
        private const string ag = "PCI_SUPPORT_O3_CH";
        private const string ah = "PCI_ANALOGWIDEBANDDATA";
        private const string ai = "Pre-R090500";
        private const string aj = "R090500";
        private const string ak = "R100000";
        private const string al = "R100500";
        private const string am = "R110000";
        private const string an = "R110500";
        private const string ao = "R130000";
        private const string ap = "R130500";
        private const string aq = "R140000";
        private const string ar = "R140400";
        private const string @as = "R150000";
        private const string at = "R160000";
        private const string au = "R170000";
        private const string av = "R200000";
        private const string aw = "R210000";
        private const string ax = "R216000";
        private const string ay = "R230000";
        private const string az = "R250000";
        private const string a0 = "R290000";
        [CompilerGenerated]
        private List<string> a1;

        public PCIHandler();
        private void a();
        private int[] a(string A_0);
        private bool a(string A_0, string A_1);
        public void AddPCIOptionsForCreate(string RadioType);
        internal void AddPCIOptionsForUpgrade();
        private void b(string A_0);
        internal void SetPCIValueForForceWrite(string strFwVersionInRad);

        public List<string> PCIOptionList { get; internal set; }
    }
}

