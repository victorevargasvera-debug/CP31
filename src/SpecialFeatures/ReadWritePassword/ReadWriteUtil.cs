namespace SpecialFeatures.ReadWritePassword
{
    using System;
    using System.Security.Cryptography;

    public class ReadWriteUtil
    {
        private static readonly byte[] a;
        private static readonly byte[] b;

        static ReadWriteUtil();
        public ReadWriteUtil();
        private byte[] a(string A_0);
        private string a(byte[] A_0);
        private static string a(SHA256 A_0, string A_1);
        internal string CalculatePassword(DateTime date, string serialNumber);
        public string decryptMesg(string messg);
        public string encryptMesg(string messg);
        internal bool isHiddenPwd(string testPwd, string serialNumber);
    }
}

