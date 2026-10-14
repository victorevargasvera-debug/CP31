namespace SpecialFeatures.DVRSFiles.List
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class DVRSFileListRecSet : Recordset, ISerializable
    {
        public static int _MaxPool;
        public static int _Max;
        internal int _DynMax;
        public static int _Min;

        static DVRSFileListRecSet();
        public DVRSFileListRecSet();
        internal DVRSFileListRecSet(SerializationInfo info, StreamingContext context);
        private void a();
        private void b();
        public override FeatureNode CreateDefaultRecord();
        public void GetObjectData(SerializationInfo info, StreamingContext context);
        internal void SetValues();

        public override int MaxPool { get; }

        public override int Max { get; set; }

        public override int Min { get; set; }

        public override int CounterToMax { get; }

        public bool HasDiffs { get; }
    }
}

