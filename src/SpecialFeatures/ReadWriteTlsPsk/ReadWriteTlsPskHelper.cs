namespace SpecialFeatures.ReadWriteTlsPsk
{
    using Motorola.MackinawCPS.CoreFeatures.RadioWide;
    using System;

    public class ReadWriteTlsPskHelper
    {
        public ReadWriteTlsPskHelper();
        private static Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide a();
        private string a(string A_0);
        public static bool IsPasswordEnabled(bool readEnabled, bool writeEnabled, string encryptedPasswordValue);
        public void ResetTlsPskFields();
        public static void SetTlsPskFromCodeplugPassword();
        public void SetTlsPskHashInCodeplug(string password);
    }
}

