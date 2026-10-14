namespace SpecialFeatures.Flashport.FlashRadio
{
    using System;

    public static class FlashcodeDecoder
    {
        public static void Decode(string flashcode, ref byte[] decoded);
        public static void DecodeOldFlashcode(string flashcode, ref byte[] decoded);
    }
}

