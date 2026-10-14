namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclMDCCallHotList : FeatureNode
    {
        internal UclMDCCallHotList(Recordset parent);
        protected UclMDCCallHotList(SerializationInfo info, StreamingContext context);

        public UclMDCCallHotListHotListSection MDCCallHotList { get; }
    }
}

