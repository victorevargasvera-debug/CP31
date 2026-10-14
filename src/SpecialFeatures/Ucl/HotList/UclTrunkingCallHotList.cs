namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclTrunkingCallHotList : FeatureNode
    {
        internal UclTrunkingCallHotList(Recordset parent);
        protected UclTrunkingCallHotList(SerializationInfo info, StreamingContext context);

        public UclTrunkingCallHotListHotListSection TrunkingCallHotList { get; }
    }
}

