namespace SpecialFeatures.Flashport.FlashRadio
{
    using System;

    public static class FlashDefinitions
    {
        public const int FlashcodeSize = 0x19;
        public const int FlashcodeSizeWithoutChecksum = 0x18;
        public const int oldFlashcodeSize = 12;
        public const int FlashCodeSizeWithhyphen = 0x1d;
        public const int oldFlashcodeSizeWithHyphen = 15;
        public const int FeatDescBlkSizePreFlashcodeExpansion = 0x10;
    }
}

