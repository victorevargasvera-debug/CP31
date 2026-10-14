namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class MDCCallHotList : FeatureNode
    {
        private MDCCallHotList();
        internal MDCCallHotList(Recordset parent);
        protected MDCCallHotList(SerializationInfo info, StreamingContext context);
        internal static IAcpFeatureNode GetMDCCallHotList();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);

        public MDCCallHotListHotListSection HotListMDC { get; }
    }
}

