namespace SpecialFeatures.Comms
{
    using System;

    public static class SerialNumberValidator
    {
        private static readonly byte[] a;
        internal const short SERIALNUMBERSIZE = 10;

        static SerialNumberValidator();
        internal static bool IsCBISerialNumber(string serialNumber);
        internal static bool ValidateSerialNumber(string serialNumber);
    }
}

