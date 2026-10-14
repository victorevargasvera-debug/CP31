namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclTrunkingT2CallHotListRecset : Recordset
    {
        public static int _MaxPool;
        public static int _Max;

        static UclTrunkingT2CallHotListRecset();
        public UclTrunkingT2CallHotListRecset();
        protected UclTrunkingT2CallHotListRecset(SerializationInfo info, StreamingContext context);
        private void a();
        public override FeatureNode CreateDefaultRecord();

        public override int MaxPool { get; }

        public override int Max { get; }

        public bool HasDiffs { get; }
    }
}

