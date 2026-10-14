namespace SpecialFeatures.SystemCertificates.List
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class SystemCertificateListRecSet : Recordset, ISerializable
    {
        public static string[] systemCertificateFiles;
        public static int systemCertificateCount;
        public static int _MaxPool;
        public static int _Max;
        internal int _DynMax;
        public static int _Min;

        static SystemCertificateListRecSet();
        public SystemCertificateListRecSet();
        internal SystemCertificateListRecSet(SerializationInfo info, StreamingContext context);
        public override FeatureNode CreateDefaultRecord();
        public void GetObjectData(SerializationInfo info, StreamingContext context);
        protected override void OnFinishedAddRecord(IAcpFeatureNode record);
        internal void SetValues();

        public override int MaxPool { get; }

        public override int Max { get; set; }

        public override int Min { get; }

        public override int CounterToMax { get; }

        public bool HasDiffs { get; }
    }
}

