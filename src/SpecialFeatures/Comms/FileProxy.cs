namespace SpecialFeatures.Comms
{
    using Motorola.Common.Communication.CommonUtil;
    using Motorola.Common.Communication.Pba;
    using SSLMangrComp;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.InteropServices;

    public class FileProxy : IDeviceProxy, IDisposable
    {
        private string a;
        private PbaObject b;
        private AstroDeviceInfo c;
        private bool d;

        internal FileProxy(string deviceFile, AstroDeviceInfo info);
        private void a(bool A_0);
        private PbaObject a(string A_0);
        private bool a(PbaObject A_0, string A_1);
        public bool CBIProgram(RadioParams radioPara);
        public void Dispose();
        protected override void Finalize();
        public bool ForceWrite(RadioParams radioPara, PbaObject targetPba, ProgressChangedEventHandler prgressIndicator);
        public bool LoadTxmCertificate(RadioParams radioParam, string path);
        public string QueryTxmCertificate(RadioParams radioParam, string path);
        public PbaObject Read(RadioParams radioPara, ProgressChangedEventHandler prgressIndicator);
        public PbaObject ReadBlock(RadioParams radioPara, List<IshHeader> blockList, ProgressChangedEventHandler prgressIndicator);
        public RadioParams ReadExtendedDeviceInfo();
        public bool ResetPassword(byte[] passwordResetFileContent);
        public PresenceNotification RetrievePresenceInfo(PNConnectionInfo connectionConfig);
        public void UpdateDevice(RadioParams radioPara, PbaObject targetPba, ProgressChangedEventHandler prgressIndicator);
        public bool UpdateSN(RadioParams radioPara, string serialNumber);
        public void ValidateUpdate(RadioParams radioPara, ProgressChangedEventHandler prgressIndicator);
        public bool Write(RadioParams radioPara, PbaObject targetPba, ProgressChangedEventHandler prgressIndicator);
        public void WriteLanguagePack(RadioParams radioParam, LanguagePackData languagePackData, ProgressChangedEventHandler prgressIndicator);

        public bool CurrentRadioIsConnected { get; }
    }
}

