namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclAstroCallHotListRecset : Recordset
    {
        public static int _MaxPool;
        public static int _Max;

        static UclAstroCallHotListRecset();
        public UclAstroCallHotListRecset();
        protected UclAstroCallHotListRecset(SerializationInfo info, StreamingContext context);
        private void a();
        public override FeatureNode CreateDefaultRecord();

        public override int MaxPool { get; }

        public override int Max { get; }

        public bool HasDiffs { get; }
    }
}

