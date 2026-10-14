namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class TrunkingCallHotList : FeatureNode
    {
        private TrunkingCallHotList();
        public TrunkingCallHotList(Recordset parent);
        protected TrunkingCallHotList(SerializationInfo info, StreamingContext context);
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        internal static IAcpFeatureNode GetTrunkingCallHotList();

        public TrunkingCallHotListHotListSection HotList { get; }
    }
}

