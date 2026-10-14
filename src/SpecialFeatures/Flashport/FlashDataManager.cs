namespace SpecialFeatures.Flashport
{
    using System;
    using System.Runtime.CompilerServices;

    public static class FlashDataManager
    {
        [CompilerGenerated]
        private static FlashDocument a;

        public static void AddFeature(Recordset recset);
        public static Recordset GetFeature(int id);

        public static FlashDocument FlashDoc { get; internal set; }
    }
}

