namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class TrunkingCallListRecset : Recordset
    {
        public static int _MaxPool;
        public static int _Max;

        static TrunkingCallListRecset();
        internal TrunkingCallListRecset();
        protected TrunkingCallListRecset(SerializationInfo info, StreamingContext context);
        public override FeatureNode CreateDefaultRecord();
        public override int GetCounterToMaxCopiesOf(int index);
        protected override void OnFinishedAddRecord(IAcpFeatureNode record);

        public override int MaxPool { get; }

        public override int Max { get; }

        public override int CounterToMax { get; }

        public bool HasDiffs { get; }
    }
}

