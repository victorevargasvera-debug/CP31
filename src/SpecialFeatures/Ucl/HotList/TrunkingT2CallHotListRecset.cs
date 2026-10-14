namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class TrunkingT2CallHotListRecset : Recordset
    {
        public static int _MaxPool;
        public static int _Max;

        static TrunkingT2CallHotListRecset();
        public TrunkingT2CallHotListRecset();
        protected TrunkingT2CallHotListRecset(SerializationInfo info, StreamingContext context);
        public override FeatureNode CreateDefaultRecord();

        public override int MaxPool { get; }

        public override int Max { get; }

        public bool HasDiffs { get; }
    }
}

