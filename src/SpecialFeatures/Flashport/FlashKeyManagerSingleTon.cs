namespace SpecialFeatures.Flashport
{
    using SpecialFeatures.Flashport.FlashkeyLib;
    using System;

    public static class FlashKeyManagerSingleTon
    {
        private static FlashkeyManager a;
        private static object b;

        static FlashKeyManagerSingleTon();
        public static void ReleaseFlashKeyManager();

        public static FlashkeyManager Instance { get; }
    }
}

