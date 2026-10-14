namespace SpecialFeatures.DVRSXML
{
    using System;

    public class CRC32
    {
        private static uint[] a;

        static CRC32();
        public CRC32();
        internal static uint CalculateHashCode(string text);
    }
}

