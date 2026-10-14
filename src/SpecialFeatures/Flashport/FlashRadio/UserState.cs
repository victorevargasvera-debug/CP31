namespace SpecialFeatures.Flashport.FlashRadio
{
    using System;

    public enum UserState
    {
        ConnectStart,
        ConnectError,
        ConnectDone,
        ReadRadInfoStart,
        ReadRadInfoError,
        ReadRadInfoDone,
        CodeplugStart,
        CodeplugError,
        CodeplugDone,
        FlashingComponentStart,
        FlashingComponentError,
        FlashingComponentDone,
        FinalValidationStart,
        FinalValidationError,
        FinalValidationDone,
        UploadFirmwareStart,
        UploadFirmwareDone,
        UploadFirmwareError,
        FirmwarePackageInvalid,
        None
    }
}

