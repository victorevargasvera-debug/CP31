namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclTrunkingT2CallHotList : FeatureNode
    {
        internal UclTrunkingT2CallHotList(Recordset parent);
        protected UclTrunkingT2CallHotList(SerializationInfo info, StreamingContext context);

        public UclTrunkingT2CallHotListHotListSection TrunkingT2CallHotList { get; }
    }
}

