namespace SpecialFeatures.CxfFilePassword.Helpers
{
    using Motorola.Acp.PackUnpack.Ish;
    using Motorola.Common.Communication.CommonFile;
    using Motorola.Common.Communication.CommonUtil;
    using Motorola.Common.Communication.Pba;
    using System;

    internal class CpsCodeplugToCmpBytesConversionHelper
    {
        private const int a = 6;
        private static readonly CodeplugCommFileHeader b;

        static CpsCodeplugToCmpBytesConversionHelper();
        public CpsCodeplugToCmpBytesConversionHelper();
        private static IshItemCollection a(Codeplug A_0);
        private static byte[] a(PbaObject A_0);
        private static byte a(byte A_0);
        public static byte[] ConvertCpsCodeplugToCmpBytes(Codeplug codeplug);

        private static int IshTypeHeaderOffset { get; }

        private static int IshIdHeaderOffset { get; }

        private static int IshItemSizeHeaderOffset { get; }
    }
}

