namespace SpecialFeatures.DdiltBuilder
{
    using System;
    using System.Runtime.CompilerServices;

    public class DdiltContainer
    {
        private uint a;
        private const uint b = 0x5c;
        private ushort c;
        private uint d;
        private uint e;
        private uint f;
        private uint g;
        private uint h;
        private uint i;
        private uint j;
        private uint k;
        private uint l;
        private uint m;
        private uint n;
        private uint o;
        private uint p;
        private uint q;
        private uint r;
        private uint s;
        private DdiltGroup t;
        private DdiltGroup u;
        private DdiltGroup v;
        private byte[] w;
        [CompilerGenerated]
        private ushort[] x;

        public DdiltContainer();
        public byte[] ConvertToBytes();

        public ushort[] LifeTimeMax { get; set; }

        public uint MagicNumber { get; set; }

        public uint Reserved { get; set; }

        public uint ChecksumRange { get; set; }

        public uint Checksum { get; set; }

        public uint VectorCount { get; set; }

        public uint VersionNumber { get; set; }

        public uint CodeplugGroupID { get; set; }

        public uint CodeplugGroupVector { get; set; }

        public uint UclGroupID { get; set; }

        public uint UclGroupVector { get; set; }

        public uint SecGroupID { get; set; }

        public uint SecGroupVector { get; set; }

        public DdiltGroup CodePlugGroup { get; set; }

        public DdiltGroup UclGroup { get; set; }

        public DdiltGroup SecGroup { get; set; }
    }
}

