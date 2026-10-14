namespace SpecialFeatures.Flashport
{
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography;

    public sealed class Crc32 : HashAlgorithm
    {
        public const uint DefaultPolynomial = 0xedb88320;
        public const uint DefaultSeed = 0xffffffff;
        private static uint[] a;
        private readonly uint b;
        private readonly uint[] c;
        private uint d;

        public Crc32();
        public Crc32(uint polynomial, uint seed);
        private static byte[] a(uint A_0);
        private static uint a(uint[] A_0, uint A_1, IList<byte> A_2, int A_3, int A_4);
        private static uint[] b(uint A_0);
        public static uint Compute(byte[] buffer);
        public static uint Compute(uint seed, byte[] buffer);
        public static uint Compute(uint polynomial, uint seed, byte[] buffer);
        protected override void HashCore(byte[] buffer, int start, int length);
        protected override byte[] HashFinal();
        public override void Initialize();

        public override int HashSize { get; }
    }
}

