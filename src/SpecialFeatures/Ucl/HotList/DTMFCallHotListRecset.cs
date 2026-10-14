namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class DTMFCallHotListRecset : Recordset
    {
        public DTMFCallHotListRecset();
        protected DTMFCallHotListRecset(SerializationInfo info, StreamingContext context);
        public override FeatureNode CreateDefaultRecord();
    }
}

