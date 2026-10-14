namespace SpecialFeatures.Flashport.FlashkeyLib
{
    using IBtnWrapperLib;
    using System;
    using System.Runtime.InteropServices;

    public class FlashkeyManager
    {
        private MultiBtnWrapper a;
        private Flashkey b;
        private short c;
        private short d;
        private byte[] e;
        private int f;
        private int g;

        public FlashkeyManager();
        private bool a();
        private byte[] a(byte[] A_0);
        private bool a(out byte[] A_0, out byte[] A_1, bool A_2);
        private byte[] b(byte[] A_0);
        internal bool FindFlashkey(string modelNumber, string flashcode, FindType find);
        internal byte[] GetKeySerialNumber();
        internal object GetValue(FieldType fType);
        internal bool IsModelUpgradeKey();
        internal bool IsRefreshKey();
        internal bool UpdateUpgradesRemCounter(int howMany);
        internal bool ValidateKey();
        internal bool ValidateSerialNumber();
    }
}

