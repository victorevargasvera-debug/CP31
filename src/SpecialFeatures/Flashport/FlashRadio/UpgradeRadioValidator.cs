namespace SpecialFeatures.Flashport.FlashRadio
{
    using System;

    public class UpgradeRadioValidator
    {
        public UpgradeRadioValidator();
        public static bool IsCPSVersionLowerThanFirmwareUpgradeVersion(string cvnHostVersion, string cpsVersion);
    }
}

