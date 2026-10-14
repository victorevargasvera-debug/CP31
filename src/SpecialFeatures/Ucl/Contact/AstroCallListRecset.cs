namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class AstroCallListRecset : Recordset
    {
        public static int _MaxPool;
        public static int _Max;

        static AstroCallListRecset();
        internal AstroCallListRecset();
        protected AstroCallListRecset(SerializationInfo info, StreamingContext context);
        public override FeatureNode CreateDefaultRecord();
        public override int GetCounterToMaxCopiesOf(int index);
        protected override void OnFinishedAddRecord(IAcpFeatureNode record);

        public override int MaxPool { get; }

        public override int Max { get; }

        public bool HasDiffs { get; }

        public override int CounterToMax { get; }
    }
}

