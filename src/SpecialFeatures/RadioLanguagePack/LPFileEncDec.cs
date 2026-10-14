namespace SpecialFeatures.RadioLanguagePack
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Xml;

    public static class LPFileEncDec
    {
        internal static XmlDocument Decrypt(Stream inEncXmlStream);
        internal static XmlDocument Decrypt(string inEncXmlFile);
        internal static void Decrypt(out byte[] dataRaw, string inEncFile);
        internal static void DecryptTxt(out string dataStr, string inEncFile);
        internal static void Encrypt(byte[] dataRaw, string outEncFile);
        internal static void Encrypt(string inXmlFile, string outEncXmlFile);
        internal static void Encrypt(XmlDocument xmlDoc, string outEncXmlFile);
        internal static void EncryptTxt(string dataStr, string outEncFile);
    }
}

