namespace SpecialFeatures.DVRSFiles.List
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class DVRSFileListInnerRecset : Recordset, ISerializable
    {
        public static int _MaxPool;
        public static int _Max;
        internal int _DynMax;
        public static int _Min;
        public static int _DefaultRecordCount;

        static DVRSFileListInnerRecset();
        public DVRSFileListInnerRecset();
        internal DVRSFileListInnerRecset(SerializationInfo info, StreamingContext context);
        public override FeatureNode CreateDefaultRecord();
        public void GetObjectData(SerializationInfo info, StreamingContext context);
        internal void SetValues();

        public override int MaxPool { get; }

        public override int Max { get; set; }

        public override int Min { get; }

        public override int DefaultRecordCount { get; set; }

        public bool HasDiffs { get; }
    }
}

