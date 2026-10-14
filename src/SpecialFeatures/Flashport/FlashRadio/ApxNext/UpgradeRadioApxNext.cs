namespace SpecialFeatures.Flashport.FlashRadio.ApxNext
{
    using Motorola.Common.Communication.CommonUtil;
    using Motorola.Common.Communication.Pba;
    using Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles;
    using Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles;
    using SpecialFeatures.Comms;
    using SpecialFeatures.Flashport.FlashkeyLib;
    using SpecialFeatures.Flashport.FlashRadio;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class UpgradeRadioApxNext
    {
        private const int a = 0x385;
        private readonly ProgressUpdater b;
        private readonly bool c;

        public UpgradeRadioApxNext(BackgroundWorker worker, bool isRefresh);
        private static void a();
        private static string a(PbaObject A_0);
        private static void a(MetadataFile A_0);
        private static void a(KeyValuePair<string, bool> A_0);
        private static string a(byte[] A_0);
        private static void a(RadioParams A_0);
        private static void a(FlashkeyManager A_0);
        private static void a(string A_0);
        private static void a(IshItemCollection A_0, string A_1);
        private static void a(IDeviceProxy A_0, RadioParams A_1);
        private bool a(RadioParams A_0, MetadataFile A_1);
        private static void a(FlashkeyManager A_0, string A_1);
        private static bool a(string A_0, bool A_1);
        private static void a(string A_0, string A_1);
        private static void a(RadioParams A_0, string A_1, string A_2);
        private static bool a(string A_0, string A_1, string A_2);
        private static Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles b();
        private static string b(FlashkeyManager A_0);
        private static void b(string A_0);
        private bool b(RadioParams A_0, MetadataFile A_1);
        private static void b(FlashkeyManager A_0, string A_1);
        private static void b(string A_0, string A_1);
        private static void b(string A_0, string A_1, string A_2);
        private static Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles c();
        private static void c(string A_0);
        private static void c(string A_0, string A_1);
        private static void c(string A_0, string A_1, string A_2);
        private static void d();
        private IshItemCollection d(string A_0);
        private static void d(string A_0, string A_1);
        private static void e();
        private static void f();
        public void FlashRadio(string upgradeFile);
        private static void g();
        private static void h();
        private static void i();
        private static void j();
        private static void k();
        private static void l();
        private static void m();
        private static void n();
        private static void o();
        private static void p();
        private static void q();
        private static int r();
        private static int s();
        private IDeviceProxy t();
        private static void u();
        private static void v();
        private static void w();

        [Serializable, CompilerGenerated]
        private sealed class <>c
        {
            public static readonly UpgradeRadioApxNext.<>c <>9;
            public static Func<KeyValuePair<IshHeader, IshItem>, bool> <>9__22_0;

            static <>c();
            public <>c();
            internal bool <GetFlashcode>b__22_0(KeyValuePair<IshHeader, IshItem> it);
        }
    }
}

