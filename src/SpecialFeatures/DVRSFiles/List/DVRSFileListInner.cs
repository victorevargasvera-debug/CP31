namespace SpecialFeatures.DVRSFiles.List
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class DVRSFileListInner : FeatureNode
    {
        private DVRSFileListInner();
        public DVRSFileListInner(Recordset parent);
        protected DVRSFileListInner(SerializationInfo info, StreamingContext context);
        public override void GetObjectData(SerializationInfo info, StreamingContext context);

        public SpecialFeatures.DVRSFiles.List.DVRSFileListInnerSection DVRSFileListInnerSection { get; }
    }
}

