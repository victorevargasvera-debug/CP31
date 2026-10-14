namespace SpecialFeatures.Flashport.FlashRadio
{
    using Motorola.Common.Communication.CommonUtil;
    using Motorola.Common.Communication.Pba;
    using Motorola.CommonCPS.Server.EntityModel;
    using Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles;
    using Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles;
    using SpecialFeatures.Comms;
    using SpecialFeatures.Flashport;
    using SpecialFeatures.Flashport.FlashkeyLib;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.InteropServices;

    public sealed class UpgradeRadio
    {
        private string a;
        private string b;
        private string c;
        private FlashportUpgradeFile d;
        private FlashkeyManager e;
        private BackgroundWorker f;
        private UpgradeRadio.ProgressCallback g;
        private bool h;
        private bool i;
        private bool j;
        private RadioParams k;
        private IDeviceProxy l;
        private const int m = 0x385;
        private int n;
        private string o;
        private string p;
        private string q;
        private bool r;
        private string s;
        private bool t;
        private string u;
        private string v;
        private AstroDeviceInfo w;
        private ASTROFirmware x;
        private string y;
        private PbaObject z;
        private bool aa;

        public UpgradeRadio();
        internal UpgradeRadio(BackgroundWorker worker, bool IsRefresh);
        public UpgradeRadio(BackgroundWorker worker, bool IsRefresh, AstroDeviceInfo astrodeviceinfo, ASTROFirmware astrofwPackageDesc, string astrofwPackagePath);
        public UpgradeRadio(BackgroundWorker worker, bool IsRefresh, string modelNumber, string radioHostVersion, string hostVersion, ASTROFirmware astroFirmware);
        private void a();
        private void a(IshItemCollection A_0);
        private byte[] a(PbaObject A_0);
        private bool a(ref bool A_0);
        private void a(KeyValuePair<string, bool> A_0);
        private string a(byte[] A_0);
        private void a(ref string A_0);
        private void a(string A_0);
        private string a(string A_0, bool A_1);
        private bool a(string A_0, string A_1);
        private void a(FlashportUpgradeFile A_0, string A_1, string A_2);
        private FlashportUpgradeFile a(FlashportUpgradeFile A_0, string A_1, string A_2, string A_3);
        private void aa();
        private Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles ab();
        private Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles ac();
        private void ad();
        public void ApplyModelTiering();
        private void b();
        private void b(IshItemCollection A_0);
        private void b(string A_0);
        private static bool b(string A_0, bool A_1);
        private void b(string A_0, string A_1);
        private void b(FlashportUpgradeFile A_0, string A_1, string A_2);
        public void BeginFlashUpgrade();
        public UpdateDeviceData BuildUpdateDataForCruncher(out AstroDeviceInfo updatedDeviceInfo);
        private bool c();
        private void c(IshItemCollection A_0);
        public static bool checkPCIFieldsValue(string modelNumber, string upgradeFileVersion, string flashcode);
        public void Connect();
        private IshItemCollection d();
        internal void DepotFlashRadio(string upgradeFile, string newFlashCode);
        private string e();
        private void f();
        internal void FlashRadio(string upgradeFile);
        public PbaObject FlashRadioWithPba(DeviceInfo codeplugDeviceInfo, string upgradeFile, PbaObject codeplugPba);
        private void g();
        private void h();
        private void i();
        internal bool IsConsoletteBoardFlashUpdateNeeded(ref string ConBrdType);
        internal bool IsOptionBoardFlashUpdateNeeded(ref string optBrdType, ref bool bComponentFound);
        private UpdateDeviceData j();
        private void k();
        private bool l();
        private void m();
        private void n();
        private void o();
        private void p();
        public void PostUpgradeCodeplugHandler(string newFlashCode);
        public void PreUpgradeCodeplugHandler();
        private void q();
        private void r();
        public IshItemCollection ReadCodeplug();
        public IshItemCollection ReadTestCodeplug();
        public void RefreshAESFields();
        private int s();
        public void SetActionTypeAfterUpgrade();
        public void SetCodeplugFields(string flashcode);
        public void SetDeviceInfoField();
        public void SetProductModelIdentifierField();
        public void SetRequiredFirmwareVersionField();
        public static void SetWindNoiseReductionLevelForAccessories();
        public void SyncActiveMicForBTPTT();
        private int t();
        private void u();
        public void UnpackCodeplug(IshItemCollection radioCodeplug);
        private void v();
        private void w();
        private void x();
        private void y();
        private void z();

        public string fileHostVersion { get; set; }

        public string BBFBundleVersion { get; set; }

        public string RadioHostVersion { get; set; }

        public bool IsRadioTakesBBF { get; set; }

        private class ProgressCallback : DeviceServiceHandler
        {
            private BackgroundWorker a;
            private int b;
            private int c;

            public ProgressCallback(BackgroundWorker worker, int steps, int currStep);
            public void ProgressUpdate(double progress, string status);
            public void UpdateRadioProgress(object sender, ProgressChangedEventArgs e);

            public int MaxSteps { get; set; }

            public int CurrentStep { get; set; }
        }
    }
}

