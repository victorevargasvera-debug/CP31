namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class PhoneCallListRecset : Recordset
    {
        public static int _MaxPool;
        public static int _Max;

        static PhoneCallListRecset();
        public PhoneCallListRecset();
        protected PhoneCallListRecset(SerializationInfo info, StreamingContext context);
        private void a(IAcpFeatureNode A_0);
        private void a(IAcpFeatureNode A_0, IAcpFeatureNode A_1);
        public override FeatureNode CreateDefaultRecord();
        public override int GetCounterToMaxCopiesOf(int index);
        protected override void OnFinishedAddRecord(IAcpFeatureNode record);
        protected override void OnFinishedMoveRecord(IAcpFeatureNode record, IAcpFeatureNode targetRecord);

        public override int MaxPool { get; }

        public override int Max { get; }

        public bool HasDiffs { get; }

        public override int CounterToMax { get; }
    }
}

