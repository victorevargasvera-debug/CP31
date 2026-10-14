namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class TrunkingCallList : FeatureNode
    {
        private TrunkingCallList();
        internal TrunkingCallList(Recordset parent);
        protected TrunkingCallList(SerializationInfo info, StreamingContext context);
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        internal static IAcpFeatureNode GetTrunkingCallList();
        internal bool IsDefaultNode();

        public TrunkingCallListCallListSection CallList { get; }

        public override string ReferenceKey { get; }
    }
}

