namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclDTMFCallHotListRecset : Recordset
    {
        public UclDTMFCallHotListRecset();
        protected UclDTMFCallHotListRecset(SerializationInfo info, StreamingContext context);
        private void a();
        public override FeatureNode CreateDefaultRecord();
    }
}

