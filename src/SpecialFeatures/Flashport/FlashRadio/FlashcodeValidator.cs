namespace SpecialFeatures.Flashport.FlashRadio
{
    using System;

    public static class FlashcodeValidator
    {
        internal static byte CalculateFlashCodeCheckDigit(string flashCode);
        public static bool Validate(string flashcode);
        public static bool ValidateOldFlashcode(string flashcode);
    }
}

