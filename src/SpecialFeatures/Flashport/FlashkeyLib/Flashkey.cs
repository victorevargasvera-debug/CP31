namespace SpecialFeatures.Flashport.FlashkeyLib
{
    using System;
    using System.Runtime.InteropServices;

    internal sealed class Flashkey
    {
        private byte[] a;
        private FlashkeyLayout b;
        private byte[] c;
        private short d;
        private int e;
        private int f;

        public Flashkey();
        internal Flashkey(Flashkey key);
        internal void GetKeyData(out byte[] keyData);
        internal void GetSerialNumber(out byte[] serial);
        internal object GetValue(FieldType fType, byte[] decData);
        internal bool InitFlashkey(byte[] keyData, byte[] serialNumber, byte[] decData);
        internal void StoreKeyData(byte[] keyData);
        internal bool UpdateUpgradesRemCounter(int howMany, ref byte[] decData);

        internal int KeyDecDataSize { get; }

        internal int LayoutVersion { get; }

        public short KeyType { get; }
    }
}

