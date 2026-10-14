namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclQCIICallHotListRecset : Recordset
    {
        public UclQCIICallHotListRecset();
        protected UclQCIICallHotListRecset(SerializationInfo info, StreamingContext context);
        private void a();
        public override FeatureNode CreateDefaultRecord();
    }
}

