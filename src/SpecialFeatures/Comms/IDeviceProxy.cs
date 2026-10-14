namespace SpecialFeatures.Comms
{
    using Motorola.Common.Communication.Pba;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.InteropServices;

    public interface IDeviceProxy : IDisposable
    {
        bool CBIProgram(RadioParams radioPara);
        bool ForceWrite(RadioParams radioPara, PbaObject targetPba, ProgressChangedEventHandler prgressIndicator);
        bool LoadTxmCertificate(RadioParams radioParam, string path);
        string QueryTxmCertificate(RadioParams radioParam, string path);
        PbaObject Read(RadioParams radioPara, ProgressChangedEventHandler prgressIndicator);
        PbaObject ReadBlock(RadioParams radioPara, List<IshHeader> blockList, ProgressChangedEventHandler prgressIndicator);
        RadioParams ReadExtendedDeviceInfo();
        bool ResetPassword(byte[] passwordResetFileContent);
        void UpdateDevice(RadioParams radioPara, PbaObject targetPba, ProgressChangedEventHandler prgressIndicator);
        bool UpdateSN(RadioParams radioPara, string serialNumber);
        void ValidateUpdate(RadioParams radioPara, ProgressChangedEventHandler prgressIndicator);
        bool Write(RadioParams radioPara, PbaObject targetPba, ProgressChangedEventHandler prgressIndicator);
        void WriteLanguagePack(RadioParams radioParam, LanguagePackData languagePackData, ProgressChangedEventHandler prgressIndicator);

        bool CurrentRadioIsConnected { get; }
    }
}

