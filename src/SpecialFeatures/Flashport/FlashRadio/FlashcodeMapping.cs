namespace SpecialFeatures.Flashport.FlashRadio
{
    using System;

    public static class FlashcodeMapping
    {
        internal const int FLASHCODE_MAPSIZE = 0x40;
        private static readonly char[] a;

        static FlashcodeMapping();
        internal static char GetFlashcodeCharValue(int i);
        internal static int GetFlashcodeIntValue(char c);
        internal static bool IsCharInFlashcodeMap(char c);
    }
}

