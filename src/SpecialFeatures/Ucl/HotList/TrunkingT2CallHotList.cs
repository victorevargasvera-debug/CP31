namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class TrunkingT2CallHotList : FeatureNode
    {
        private TrunkingT2CallHotList();
        internal TrunkingT2CallHotList(Recordset parent);
        protected TrunkingT2CallHotList(SerializationInfo info, StreamingContext context);
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        internal static IAcpFeatureNode GetTrunkingT2CallHotList();

        public TrunkingT2CallHotListHotListSection HotListT2 { get; }
    }
}

