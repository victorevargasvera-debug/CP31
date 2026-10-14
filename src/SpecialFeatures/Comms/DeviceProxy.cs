namespace SpecialFeatures.Comms
{
    using Motorola.Common.Communication.CommonUtil;
    using Motorola.Common.Communication.Pba;
    using Motorola.Common.Communication.Service;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.InteropServices;

    public class DeviceProxy : IDeviceProxy, IDisposable
    {
        private DeviceServiceHandler a;
        private IDeviceOperation b;
        private ProgressChangedEventHandler c;
        private DeviceInfo d;
        private bool e;
        private RadioOperation f;
        private bool g;
        private readonly string h;
        private bool i;

        public DeviceProxy(DeviceInfo deviceInfo, RadioOperation radioOp, string psk);
        private void a();
        private void a(bool A_0);
        private bool a(DeviceInfo A_0, DeviceInfo A_1);
        private void a(object A_0, DeviceEventArgs A_1);
        private void a(object A_0, ProgressChangedEventArgs A_1);
        public bool CBIProgram(RadioParams radioPara);
        public void Dispose();
        protected override void Finalize();
        public bool ForceWrite(RadioParams radioPara, PbaObject targetPba, ProgressChangedEventHandler prgressIndicator);
        public bool LoadTxmCertificate(RadioParams radioParam, string path);
        public string QueryTxmCertificate(RadioParams radioParam, string path);
        public PbaObject Read(RadioParams radioPara, ProgressChangedEventHandler prgressIndicator);
        public PbaObject ReadBlock(RadioParams radioPara, List<IshHeader> blockList, ProgressChangedEventHandler prgressIndicator);
        public DeviceInfo ReadDeviceInfo();
        public RadioParams ReadExtendedDeviceInfo();
        public bool ResetPassword(byte[] passwordResetFileContent);
        public void UpdateDevice(RadioParams radioPara, PbaObject targetPba, ProgressChangedEventHandler prgressIndicator);
        public bool UpdateSN(RadioParams radioPara, string serialNumber);
        public void ValidateUpdate(RadioParams radioPara, ProgressChangedEventHandler prgressIndicator);
        public bool Write(RadioParams radioPara, PbaObject targetPba, ProgressChangedEventHandler prgressIndicator);
        public void WriteLanguagePack(RadioParams radioParam, LanguagePackData languagePackData, ProgressChangedEventHandler prgressIndicator);

        public bool CurrentRadioIsConnected { get; }
    }
}

