namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclPhoneCallHotListRecset : Recordset
    {
        public UclPhoneCallHotListRecset();
        protected UclPhoneCallHotListRecset(SerializationInfo info, StreamingContext context);
        private void a();
        public override FeatureNode CreateDefaultRecord();

        public bool HasDiffs { get; }
    }
}

