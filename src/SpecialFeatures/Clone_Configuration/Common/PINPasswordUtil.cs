namespace SpecialFeatures.Clone_Configuration.Common
{
    using SpecialFeatures.Comms;
    using System;
    using System.Runtime.InteropServices;

    public class PINPasswordUtil
    {
        public PINPasswordUtil();
        private static string a(string A_0);
        public static void RestorePasswordsBackEncrypt(string originalPwd);
        public static string UpdatePasswordsToClear(string encryptedPswd);
        public static void UpdatePINPasswordFromRadio(RadioIdInfo tempRadioIds);
    }
}

