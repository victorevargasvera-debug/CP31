namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class AstroCallHotList : FeatureNode
    {
        private AstroCallHotList();
        internal AstroCallHotList(Recordset parent);
        protected AstroCallHotList(SerializationInfo info, StreamingContext context);
        internal static IAcpFeatureNode GetAstroCallHotList();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);

        public AstroCallHotListHotListSection HotListAstro { get; }
    }
}

