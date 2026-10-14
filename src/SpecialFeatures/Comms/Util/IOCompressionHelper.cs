namespace SpecialFeatures.Comms.Util
{
    using System;
    using System.IO.Compression;

    public class IOCompressionHelper : IIOCompressionHelper
    {
        public IOCompressionHelper();
        public ZipArchive OpenRead(string path);
    }
}

