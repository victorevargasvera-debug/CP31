namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclQCIICallHotList : FeatureNode
    {
        internal UclQCIICallHotList(Recordset parent);
        protected UclQCIICallHotList(SerializationInfo info, StreamingContext context);

        public UclQCIICallHotListHotListSection QCIICallHotList { get; }
    }
}

