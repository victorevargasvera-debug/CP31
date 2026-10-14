namespace SpecialFeatures.Flashport.FlashRadio
{
    using System;

    internal enum UpgradeRadioResult
    {
        Success,
        RadioNotSupported,
        InvalidUpgradeFileContents,
        ValidFlashkeyNotFound,
        NoUpgradesLeftInFlashkey,
        FlashkeyValidationFailed,
        ModelNumberValidationFailed,
        FlashcodeValidationFailed,
        FlashRadioFailed,
        CodeplugUpdateFailed,
        GetRadioParametersFailed,
        UpgradeFileNotFound,
        SerialNumberValidationFailed,
        CBISerialNumber,
        UpgradeRadioFailed
    }
}

