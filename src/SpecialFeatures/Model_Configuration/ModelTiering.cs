namespace SpecialFeatures.Model_Configuration
{
    using AcpCommonLib;
    using AcpModelTieringLib;
    using Motorola.MackinawCPS.CoreFeatures.RadioWide;
    using SpecialFeatures.Flashport.FlashRadio;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class ModelTiering : IDisposable
    {
        private const int a = 0x7fffffff;
        private const int b = 1;
        private const int c = 1;
        private const int d = 12;
        private const int e = 6;
        private const int f = 7;
        private const int g = 8;
        private const int h = 5;
        private const int i = 4;
        private const int j = 3;
        private const int k = 2;
        private const int l = 1;
        private const int m = 5;
        private const int n = 6;
        private const int o = 10;
        private const int p = 11;
        private const int q = 14;
        private const int r = 1;
        private const int s = 15;
        private const int t = 3;
        private const int u = 3;
        public const string DEFAULT_MODEL = "H97TGD9PW1AN";
        public const string DEFAULT_MOBILE_MODEL = "M30TSS9PW1AN";
        private const string v = "MENUITEM";
        private const string w = "ApxH0.cps";
        private const string x = "Model_Tiering.g.xml";
        private const string y = "ALWAYS";
        private const string z = "NEVER";
        private const string aa = "DEFAULT";
        private const string ab = "PORTABLE";
        private const string ac = "MOBILE";
        private const string ad = "FPS_DEPLOYMENT";
        private const string ae = "DEPOT_DEPLOYMENT";
        private const string af = "SOURCE_CPG_VERSION_LT_5";
        private const string ag = "SOURCE_CPG_VERSION_LT_6";
        private const string ah = "SOURCE_CPG_VERSION_LT_11";
        private const string ai = "SOURCE_CPG_VERSION_LT_2016_Q1SER";
        private const string aj = "SOURCE_PCI_EXPANDED_MDC_E_F";
        private const string ak = "SOURCE_PCI_DISABLE_EMERGENCY_CALL_INDICATIONS_CAPABLE";
        private const string al = "SOURCE_PCI_PASS_ALARM_FILTER_CAPABLE";
        private const string am = "STRING_PCI_MOSCAD3000_ENHANCE";
        private const string an = "STRING_PCI_PERSONNEL_ACCOUNTABILITY_ALERT_CAPABILITY";
        private const string ao = "STRING_PCI_USER_SELECTABLE_PL_ENHANCEMENT";
        private const string ap = "STRING_PCI_CONSOLIDATED_ACTIONS_ENHANCEMENT";
        private const string aq = "STRING_PCI_LIMITED_ISSI_DVRS_OPERATION_CAPABLE";
        private const string ar = "STRING_PCI_ACTIVE_MIC_FOR_PTT";
        private const string @as = "STRING_PCI_APX_SINGLETONE_CAPABLE";
        private const string at = "STRING_PCI_ENHANCED_ARS";
        private const string au = "STRING_PCI_EMERGENCY_CALL_ONLY_WITH_HOT_MIC_CAPABLE";
        private const string av = "STRING_PCI_ZONE_CLONE_CAPABLE";
        private const string aw = "STRING_PCI_EMERGENCY_CALL_TERMINATION";
        private const string ax = "STRING_PCI_IPS_CAPABLE";
        private const string ay = "STRING_PCI_DISABLE_WIND_NOISE_REDUCTION_LEVEL_FOR_ACCESSORIES";
        private const string az = "SOURCE_PCI_RADIOLOCK_EXTENSION_CAPABLE";
        private const string a0 = "STRING_PCI_EXTENDED_PL_TONE_SET";
        private const string a1 = "STRING_PCI_ALLOW_PSU_SECURE";
        private const string a2 = "STRING_PCI_UCL_CONTACTS_LIMITATION_ENHANCEMENT";
        private const string a3 = "STRING_PCI_DVRS_RANGE_EXT";
        private const string a4 = "PCI_ADP_FLASHCODE_GATING";
        private const string a5 = "STRING_PCI_INDIRECT_PTT_AUDIO_ROUTING_PCI";
        private const string a6 = "SIREN_LIGHTS_KEYPAD";
        private const string a7 = "INTERNATIONAL";
        private const string a8 = "I";
        private const string a9 = "QA03055";
        private const string ba = "EMG_RVT";
        private const string bb = "EMG_BEACON_ROUTING";
        private const string bc = "MAN_DOWN_EMER_PRF_CFG";
        private const string bd = "EMER_TONE_CFG";
        private const string be = "H17";
        private const string bf = "GA01033";
        private const string bg = "BASIC_CONTROL_HEAD";
        private const string bh = "HOT_MIC";
        private const string bi = "AUDIBLE_EMERGENCY_BEACON_FOR_MOBILE";
        private const string bj = "QA04865";
        private const string bk = "AUDIO_ENH";
        private const string bl = "QA07468";
        private const string bm = "QA07521";
        private const string bn = "STRING_PCI_MARVELL_DNP";
        private const string bo = "GA01788";
        private const string bp = "PCI_SUPPORT_O3_CH";
        private const string bq = "PCI_ANALOGWIDEBANDDATA";
        private static string[] br;
        private ModelTiering.ActionTypes bs;
        private ModelTiering.TargetTypes bt;
        private string bu;
        private List<string> bv;
        private bool bw;
        private string bx;
        private string by;
        private Dictionary<string, bool> bz;
        private Dictionary<string, int> b0;
        private FlashcodeTable b1;
        private CModelTieringEngine b2;
        private Dictionary<string, List<string>> b3;

        static ModelTiering();
        public ModelTiering(string modelNumber, string flashCode);
        public ModelTiering(string strModelNumber, ModelTiering.ActionTypes action, ModelTiering.TargetTypes target, bool forComparedCodeplug);
        private void a();
        private void a(IAcpRecordset A_0);
        private void a(ref Dictionary<string, bool> A_0);
        private void a(bool A_0);
        private void a(string A_0);
        private void a(IAcpField A_0, bool A_1);
        private void a(ref Dictionary<string, bool> A_0, bool A_1);
        private bool a(Option A_0, int A_1);
        private int a(List<string> A_0, string A_1);
        private static bool a(int A_0, string A_1);
        private bool a(string A_0, string A_1);
        private void a(ref IAcpField A_0, string A_1, bool A_2, bool A_3);
        private void aa(ref Dictionary<string, bool> A_0);
        private void ab(ref Dictionary<string, bool> A_0);
        private void ac(ref Dictionary<string, bool> A_0);
        private void ad(ref Dictionary<string, bool> A_0);
        private void ae(ref Dictionary<string, bool> A_0);
        private void af(ref Dictionary<string, bool> A_0);
        private void ag(ref Dictionary<string, bool> A_0);
        private void ah(ref Dictionary<string, bool> A_0);
        private void ai(ref Dictionary<string, bool> A_0);
        private void aj(ref Dictionary<string, bool> A_0);
        private void ak(ref Dictionary<string, bool> A_0);
        private void al(ref Dictionary<string, bool> A_0);
        private void am(ref Dictionary<string, bool> A_0);
        private void an(ref Dictionary<string, bool> A_0);
        private void ao(ref Dictionary<string, bool> A_0);
        public void ApplyTiering(bool bflashportApplyTiering);
        public void ApplyTieringForComparedMC();
        public void ApplyTieringForVirtualFields();
        private Dictionary<string, int> b();
        private void b(ref Dictionary<string, bool> A_0);
        private void b(string A_0);
        private bool c();
        private bool c(string A_0);
        private void c(ref Dictionary<string, bool> A_0);
        public void CheckForModelTieringFile();
        private bool d(string A_0);
        private void d(ref Dictionary<string, bool> A_0);
        public void Dispose();
        private int[] e(string A_0);
        private void e(ref Dictionary<string, bool> A_0);
        private bool f(string A_0);
        private void f(ref Dictionary<string, bool> A_0);
        internal bool FindModel(string strModelNumber);
        public void FPSInitializeOrderedOptions(bool forComparedCodeplug);
        private string g(string A_0);
        private void g(ref Dictionary<string, bool> A_0);
        internal List<KeyValuePair<string, bool>> GetPCIBitsToBeSet(string strHostVersion);
        internal int GetRecordsetDataFromEngine(string strFullyQualifiedRecordsetName, ModelTiering.RecsetAttributeTypes attributeToRetrieve);
        internal bool GetRecordsetVisibilityFromEngine(string strFullyQualifiedRecordsetName, ModelTiering.RecsetAttributeTypes attributeToRetrieve);
        private void h(ref Dictionary<string, bool> A_0);
        private void i(ref Dictionary<string, bool> A_0);
        public static bool IsModelMobileByModelNumber(string modelNumber);
        internal bool IsOptionAvailableForModel(string strModelNumber, string strHOption);
        private void j(ref Dictionary<string, bool> A_0);
        private void k(ref Dictionary<string, bool> A_0);
        private void l(ref Dictionary<string, bool> A_0);
        public void LoadAliasList();
        private void m(ref Dictionary<string, bool> A_0);
        private void n(ref Dictionary<string, bool> A_0);
        private void o(ref Dictionary<string, bool> A_0);
        private void p(ref Dictionary<string, bool> A_0);
        private void q(ref Dictionary<string, bool> A_0);
        private void r(ref Dictionary<string, bool> A_0);
        public void RecrefFixup();
        internal void RecrefFixup1();
        internal void RestoreUtilityMackIfErrorOccurs(bool bIsMobile);
        private void s(ref Dictionary<string, bool> A_0);
        private void t(ref Dictionary<string, bool> A_0);
        private void u(ref Dictionary<string, bool> A_0);
        public void UpdateUtilityMackModelType();
        private void v(ref Dictionary<string, bool> A_0);
        private void w(ref Dictionary<string, bool> A_0);
        private void x(ref Dictionary<string, bool> A_0);
        private void y(ref Dictionary<string, bool> A_0);
        private void z(ref Dictionary<string, bool> A_0);

        private Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RadioWideRef { get; }

        public List<string> FPSCustomizationOptions { set; }

        internal string MTFPath { get; }

        private bool IsModelMobile { get; }

        [Serializable, CompilerGenerated]
        private sealed class <>c
        {
            public static readonly ModelTiering.<>c <>9;
            public static Func<IAcpField, bool> <>9__115_0;

            static <>c();
            public <>c();
            internal bool <ApplyTieringForVirtualFields>b__115_0(IAcpField c);
        }

        public enum ActionTypes
        {
            NONE,
            NEW,
            OPEN,
            FLASHPORT,
            DEPOT
        }

        public enum RecsetAttributeTypes
        {
            MaxRecords,
            MaxPoolRecords,
            MinRecords,
            DefaultRecords,
            Visibility
        }

        public enum TargetTypes
        {
            NONE,
            ALL,
            RECORDSETS,
            FIELDS
        }
    }
}

