namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class TrunkingT2CallList : FeatureNode
    {
        private TrunkingT2CallList();
        internal TrunkingT2CallList(Recordset parent);
        protected TrunkingT2CallList(SerializationInfo info, StreamingContext context);
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        internal static IAcpFeatureNode GetTrunkingT2CallList();
        internal bool IsDefaultNode();

        public TrunkingT2CallListCallListSection CallListT2 { get; }

        public override string ReferenceKey { get; }
    }
}

