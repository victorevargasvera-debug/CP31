namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclDTMFCallHotList : FeatureNode
    {
        internal UclDTMFCallHotList(Recordset parent);
        protected UclDTMFCallHotList(SerializationInfo info, StreamingContext context);

        public UclDTMFCallHotListHotListSection DTMFCallHotList { get; }
    }
}

