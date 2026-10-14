namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclTrunkingCallHotListRecset : Recordset
    {
        public static int _MaxPool;
        public static int _Max;

        static UclTrunkingCallHotListRecset();
        public UclTrunkingCallHotListRecset();
        protected UclTrunkingCallHotListRecset(SerializationInfo info, StreamingContext context);
        private void a();
        public override FeatureNode CreateDefaultRecord();

        public override int MaxPool { get; }

        public override int Max { get; }

        public bool HasDiffs { get; }
    }
}

