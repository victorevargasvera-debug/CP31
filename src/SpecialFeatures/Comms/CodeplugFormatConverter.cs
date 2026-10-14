namespace SpecialFeatures.Comms
{
    using Motorola.Common.Communication.CommonUtil;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class CodeplugFormatConverter
    {
        private const int a = 6;
        private byte[] b;

        public CodeplugFormatConverter();
        private Dictionary<int, int> a(IshItemCollection A_0);
        private ushort a(MemoryStream A_0);
        internal Dictionary<int, MemoryStream> Convert(IshItemCollection collection);
        internal IshItemCollection Convert(Dictionary<int, MemoryStream> codeplug);
    }
}

