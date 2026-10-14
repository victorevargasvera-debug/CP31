namespace SpecialFeatures.Flashport.FlashRadio.ApxNext
{
    using System;

    public enum ProgressStage
    {
        BasicProgress,
        FindValidDevice,
        ConnectDone,
        ValidateUserParams,
        RadioSerialValidated,
        ReadTheCodeplugStart,
        UnpackTheCodeplug,
        FlashingRadio,
        FlashingRadioError,
        UploadFirmware,
        UploadFirmwareDone,
        FirmwarePackageInvalid
    }
}

