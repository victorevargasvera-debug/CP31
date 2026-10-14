namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class TrunkingCallHotListRecset : Recordset
    {
        public static int _MaxPool;
        public static int _Max;

        static TrunkingCallHotListRecset();
        public TrunkingCallHotListRecset();
        protected TrunkingCallHotListRecset(SerializationInfo info, StreamingContext context);
        public override FeatureNode CreateDefaultRecord();

        public override int MaxPool { get; }

        public override int Max { get; }

        public bool HasDiffs { get; }
    }
}

