namespace SpecialFeatures.DVRSFiles.List
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class DVRSFileList : FeatureNode
    {
        internal DVRSFileList(Recordset parent);
        protected DVRSFileList(SerializationInfo info, StreamingContext context);
        internal static IAcpFeatureNode GetDVRSFile();

        public DVRSFileLabtoolSection Labtool { get; }
    }
}

