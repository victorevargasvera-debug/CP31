namespace SpecialFeatures.Clone_Configuration.Common
{
    using System;

    public static class DataModemPasswordUtil
    {
        private static string a;
        private static ClearAndRestorePassword b;

        static DataModemPasswordUtil();
        public static void RestorePlainPasswordToCipher();
        public static void UpdateCipherPasswordsToPlain();
    }
}

