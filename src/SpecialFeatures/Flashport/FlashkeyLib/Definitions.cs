namespace SpecialFeatures.Flashport.FlashkeyLib
{
    using System;

    internal static class Definitions
    {
        internal const int FLASHCODE_LAYOUT_VERSION = 2;
        internal const int LAYOUT_VERSION_NEW_MODEL = 3;
        internal const int EXPANDED_FLASHCODE_STRING_VERSION = 4;
        internal const byte MSB1 = 0x80;
        internal const string REFRESHMODEL = "R00RRR0RR0RRRR0R";
        internal const int FORMATTED_FLASHCODE_SIZE = 15;
        internal const int FLASHCODE_MAPSIZE = 0x40;
        internal const int KEYSERNOSIZE = 8;
        internal const int MAXFKEYSIZE = 0x100;
        internal const string FlashkeyFile = "MOTF.000";
        internal const int DATA_START_PAGE = 8;
        internal const short FAMILY1994 = 4;
        internal const short FAMILY1963 = 0x18;
    }
}

