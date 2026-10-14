namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclMDCCallHotListRecset : Recordset
    {
        public static int _MaxPool;
        public static int _Max;

        static UclMDCCallHotListRecset();
        public UclMDCCallHotListRecset();
        protected UclMDCCallHotListRecset(SerializationInfo info, StreamingContext context);
        private void a();
        public override FeatureNode CreateDefaultRecord();

        public bool HasDiffs { get; }

        public override int MaxPool { get; }

        public override int Max { get; }
    }
}

