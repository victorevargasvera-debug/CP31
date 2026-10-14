namespace SpecialFeatures.Flashport.FlashkeyLib
{
    using System;

    internal sealed class Crc8Generator
    {
        private readonly byte[] a;

        internal Crc8Generator();
        internal byte Compute(byte[] buffer, int index, int count, byte crc8);
    }
}

