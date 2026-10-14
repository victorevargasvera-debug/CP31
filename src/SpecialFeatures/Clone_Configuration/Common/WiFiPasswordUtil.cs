namespace SpecialFeatures.Clone_Configuration.Common
{
    using Motorola.MackinawCPS.CoreFeatures.DataWide;
    using System;
    using System.Collections.Generic;
    using System.Timers;
    using System.Windows;

    public class WiFiPasswordUtil
    {
        private static List<string> a;
        private static int b;
        private const int c = 0x3e8;
        private const int d = 0xdbba0;
        private static Timer e;
        private static bool f;
        private static readonly Dictionary<string, string> g;
        private static readonly Dictionary<string, string> h;
        private static ClearAndRestorePassword i;

        static WiFiPasswordUtil();
        public WiFiPasswordUtil();
        private static void a();
        private static bool a(ConfiguredNetworksListInnerRecset A_0);
        private static bool a(DataModemTableInnerRecset A_0);
        private static void a(Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide A_0);
        private static void a(object A_0, ElapsedEventArgs A_1);
        private static bool b();
        private static bool b(ConfiguredNetworksListInnerRecset A_0);
        private static bool b(DataModemTableInnerRecset A_0);
        private static void b(Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide A_0);
        private static bool c();
        public static bool IsTimerRefreshedAndWiFiPasswordValidationSkept(bool isUpdated);
        internal static bool NeedValidation();
        internal static bool OpenValidateDlg(Window parent);
        internal static void RefreshSessionTimer();
        public static void ResetSessionTimer();
        public static void RestorePlainPasswordToCipher();
        public static void UpdateCipherPasswordsToPlain();
        internal static void WaitNextValidate();
    }
}

