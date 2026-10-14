namespace SpecialFeatures.Security
{
    using AcpASKLib;
    using AcpBusinessLayer;
    using AcpCommonLib;
    using AcpCommonLib.UndoRedo;
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Runtime.InteropServices;

    public static class ASKConstraints
    {
        private static SystemKeyLoadedEventHandler a;
        private static ProtectionOption b;
        private static bool c;
        private const int d = 1;
        private static Dictionary<IAcpField, IAcpField> e;
        private static int f;

        static ASKConstraints();
        private static void a();
        private static bool a(AcpRecRefField A_0);
        private static void a(IAcpFeatureNode A_0);
        private static bool a(IAcpFeatureSection A_0);
        private static bool a(IAcpField A_0);
        private static void a(IAcpFeatureSection A_0, ContainerTask A_1);
        private static IAcpField a(IAcpFeatureSection A_0, string A_1);
        private static void a(IAcpField A_0, ContainerTask A_1);
        private static void a(object A_0, SystemKeyLoadedEventArgs A_1);
        private static void a(string A_0, IAcpFeatureNode A_1);
        private static void a(IAcpFeatureNode A_0, IAcpField A_1, KeyType A_2, AccessRecord A_3, ContainerTask A_4);
        private static void b();
        private static void b(IAcpFeatureNode A_0);
        private static bool b(IAcpFeatureSection A_0);
        private static bool b(IAcpField A_0);
        private static void b(IAcpFeatureSection A_0, ContainerTask A_1);
        private static void c();
        private static void c(IAcpFeatureNode A_0);
        private static bool c(IAcpFeatureSection A_0);
        private static bool c(IAcpField A_0);
        private static void c(IAcpFeatureSection A_0, ContainerTask A_1);
        internal static void CoverageTypeValueSetter(IAcpFeatureSection self, ContainerTask task);
        private static void d();
        private static void d(IAcpFeatureNode A_0);
        private static bool d(IAcpFeatureSection A_0);
        private static bool d(IAcpField A_0);
        private static void e();
        private static bool e(IAcpFeatureSection A_0);
        private static bool e(IAcpField A_0);
        private static void f();
        public static void Initialize();
        internal static bool IsASKRequired(bool trkSysGeneralAskRequired);
        internal static bool IsPermissionGranted(IAcpField self);
        internal static bool IsValuePermitted(IAcpField self);
        public static void KeyFieldValueSetter(IAcpFeatureSection self, ContainerTask task);
        public static void OnEmbeddedRecordsetEventHandler(object sender, NotifyCollectionChangedEventArgs e);
        public static void OnTopLevelRecordsetEventHandler(object sender, NotifyCollectionChangedEventArgs e);
        internal static void RadWideGeneral_PropertyChanged(object sender, PropertyChangedEventArgs e);
        public static void RefKeyFieldValueSetter(IAcpFeatureSection self, ContainerTask task);
        internal static void SystemTypeValueSetter(IAcpFeatureSection self, ContainerTask task);
        internal static void TrkSysGeneral_PropertyChanged(object sender, PropertyChangedEventArgs e);
        internal static void TrkSysGeneral_PropertyChanging(object sender, PropertyChangingEventArgs e);
    }
}

