namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class MDCCallList : FeatureNode
    {
        private MDCCallList();
        internal MDCCallList(Recordset parent);
        protected MDCCallList(SerializationInfo info, StreamingContext context);
        internal static IAcpFeatureNode GetMDCCallList();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        internal bool IsDefaultNode();

        public MDCCallListCallListSection CallListMDC { get; }

        public override string ReferenceKey { get; }
    }
}

