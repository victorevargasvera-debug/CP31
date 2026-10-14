namespace SpecialFeatures.Security
{
    using AcpASKLib;
    using AcpCommonLib;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public static class FieldMapManager
    {
        private static ArrayList a;
        private static Dictionary<string, FieldMapInfo> b;
        private static Type[] c;

        static FieldMapManager();
        private static void a();
        private static IAcpFeatureNode a(IAcpFeatureNode A_0);
        private static IAcpField a(IAcpFeatureNode A_0, string A_1);
        private static FieldMapInfo a(Feature A_0, KeyType A_1);
        private static FieldMapInfo a(string A_0, KeyType A_1);
        private static void b();
        private static IAcpFeatureNode b(IAcpFeatureNode A_0);
        private static IAcpFeatureNode b(IAcpFeatureNode A_0, string A_1);
        internal static AccessElementIDType GetElementID(IAcpField self);
        internal static Feature GetFeature(CpsFeatureID id);
        internal static Feature GetFeature(string name);
        internal static FieldMapInfo GetFieldMapInfo(string cpsFieldName);
        internal static void GetKeyFieldInfo(IAcpField self, out KeyType type, out IAcpField sysIDField, out bool trkSysGeneralAskRequired);
        internal static bool GetTrkSysGeneralAskRequired(IAcpFeatureNode cpsTrkSysNode);
        internal static KeyType GetTrunkingKeyType(IAcpFeatureNode cpsTrkSysNode);
        internal static IAcpField GetTrunkingSysIDField(IAcpFeatureNode cpsTrkSysNode);

        public static ArrayList Features { get; }
    }
}

