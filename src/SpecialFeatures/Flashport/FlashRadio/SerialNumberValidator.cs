namespace SpecialFeatures.Flashport.FlashRadio
{
    using System;

    public static class SerialNumberValidator
    {
        public const short SERIALNUMBERSIZE = 10;
        private static readonly byte[] a;

        static SerialNumberValidator();
        internal static string convertSerialNumberToAscii(string serialNo);
        internal static bool IsCBISerialNumber(string serialNumber);
        internal static bool ValidateSerialNumber(string serialNumber);
    }
}

