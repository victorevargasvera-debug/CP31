namespace SpecialFeatures.Comms.Util
{
    using System;
    using System.IO.Compression;

    public interface IIOCompressionHelper
    {
        ZipArchive OpenRead(string path);
    }
}

