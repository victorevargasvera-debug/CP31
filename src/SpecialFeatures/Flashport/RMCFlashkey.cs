namespace SpecialFeatures.Flashport
{
    using SpecialFeatures.Flashport.FlashkeyLib;
    using System;

    public class RMCFlashkey : IDisposable
    {
        private string a;
        private int b;
        private int c;
        private string d;
        private string e;
        private string f;
        private string g;
        private string h;
        private string i;
        public const int FlashcodeSize = 0x19;

        public RMCFlashkey();
        private string a();
        private void a(bool A_0);
        private string b();
        private string c();
        public void Close();
        private string d();
        internal void Decode(string flashcode, ref byte[] decoded);
        public void DecrementFlashkeyCounter(int decreaseCount);
        public void Dispose();
        private string e();
        private string f();
        protected override void Finalize();
        private int g();
        private int h();
        private string i();
        public void Open();
        public bool Open(string modelNumber, string flashcode);
        protected bool Open(string modelNumber, string flashcode, FindType match);
        internal void OpenFromFlashcode(string flashcode);
        internal void OpenFromModelNumber(string modelNumber);
        public bool ValidateFlashKey();

        public string SerialNumber { get; }

        public int UpgradesRemaining { get; set; }

        public int UpgradesPurchased { get; }

        public string DateCode { get; }

        public string FactoryOrderNumber { get; }

        internal string OldFlashcode { get; }

        public string NewFlashcode { get; }

        internal string OldModelNumber { get; }

        public string NewModelNumber { get; }
    }
}

