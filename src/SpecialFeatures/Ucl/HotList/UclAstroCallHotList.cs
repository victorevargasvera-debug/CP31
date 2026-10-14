namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclAstroCallHotList : FeatureNode
    {
        internal UclAstroCallHotList(Recordset parent);
        protected UclAstroCallHotList(SerializationInfo info, StreamingContext context);

        public UclAstroCallHotListHotListSection AstroCallHotList { get; }
    }
}

