namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class PhoneCallHotListRecset : Recordset
    {
        public static int _MaxPool;
        public static int _Max;

        static PhoneCallHotListRecset();
        public PhoneCallHotListRecset();
        protected PhoneCallHotListRecset(SerializationInfo info, StreamingContext context);
        public override FeatureNode CreateDefaultRecord();
        protected override void OnFinishedAddRecord(IAcpFeatureNode record);
        protected override void OnFinishedRemoveRecord(IAcpFeatureNode record);

        public override int MaxPool { get; }

        public override int Max { get; }

        public bool HasDiffs { get; }
    }
}

