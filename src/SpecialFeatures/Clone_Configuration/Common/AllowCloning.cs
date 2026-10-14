namespace SpecialFeatures.Clone_Configuration.Common
{
    using SpecialFeatures.Flashport.FlashRadio;
    using System;
    using System.Runtime.CompilerServices;

    public static class AllowCloning
    {
        private static bool a(CodeplugData A_0);
        private static bool a(string A_0);
        private static bool a(FlashcodeTable A_0, CodeplugData A_1, CodeplugData A_2);
        private static bool a(FlashcodeTable A_0, string A_1, bool A_2, bool A_3);
        private static void a(FlashcodeTable A_0, string A_1, string A_2, ref bool A_3);
        public static bool AllowClone(CodeplugData srcData, CodeplugData targetData, bool isPortable, ref string stsErrorMsg);
        public static bool AllowCloneSpecialCases(CodeplugData srcData, CodeplugData targetData, ref byte[] srcUsedBytes, bool isPortable, ref string stsErrorMsg);
        internal static bool AllowEnhLevel1Clone(FlashcodeTable FcodeTable, CodeplugData srcData, CodeplugData targetData);
        internal static bool AllowEnhLevel2Clone(FlashcodeTable FcodeTable, CodeplugData srcData, CodeplugData targetData);
        internal static bool AllowFrequencyCloneMobile(FlashcodeTable FcodeTable, CodeplugData srcData, CodeplugData targetData);
        internal static bool AllowFrequencyClonePortable(FlashcodeTable FcodeTable, CodeplugData srcData, CodeplugData targetData);
        private static bool b(CodeplugData A_0);
        private static bool b(FlashcodeTable A_0, CodeplugData A_1, CodeplugData A_2);
        private static void b(FlashcodeTable A_0, string A_1, string A_2, ref bool A_3);
        public static bool IsModelDualBand(string modelNumber);
        public static bool IsModelHighPower(string modelNumber);
        public static bool IsModelSingleBand(string modelNumber);
        public static bool ModelNumberCheck(string sourceModel, string targetModel, bool isPortable, ref string stsErrorMsg);

        [CompilerGenerated]
        private sealed class <>c__DisplayClass16_0
        {
            public int nMaxRecs;

            public <>c__DisplayClass16_0();
            internal bool <AllowEnhLevel2Clone>b__0(AstroRecSetCountsItem x);
            internal bool <AllowEnhLevel2Clone>b__1(AstroRecSetCountsItem x);
        }

        [CompilerGenerated]
        private sealed class <>c__DisplayClass17_0
        {
            public int nMaxRecs;

            public <>c__DisplayClass17_0();
            internal bool <CheckCodeplugLimitsForEnhancements>b__0(AstroRecSetCountsItem x);
            internal bool <CheckCodeplugLimitsForEnhancements>b__1(AstroRecSetCountsItem x);
            internal bool <CheckCodeplugLimitsForEnhancements>b__2(AstroRecSetCountsItem x);
            internal bool <CheckCodeplugLimitsForEnhancements>b__3(AstroRecSetCountsItem x);
            internal bool <CheckCodeplugLimitsForEnhancements>b__4(AstroRecSetCountsItem x);
            internal bool <CheckCodeplugLimitsForEnhancements>b__5(AstroRecSetCountsItem x);
            internal bool <CheckCodeplugLimitsForEnhancements>b__6(AstroRecSetCountsItem x);
            internal bool <CheckCodeplugLimitsForEnhancements>b__7(AstroRecSetCountsItem x);
            internal bool <CheckCodeplugLimitsForEnhancements>b__8(AstroRecSetCountsItem x);
            internal bool <CheckCodeplugLimitsForEnhancements>b__9(AstroRecSetCountsItem x);
        }

        [CompilerGenerated]
        private sealed class <>c__DisplayClass17_1
        {
            public int nMaxPoolRecs;

            public <>c__DisplayClass17_1();
            internal bool <CheckCodeplugLimitsForEnhancements>b__10(AstroRecSetCountsItem x);
        }
    }
}

