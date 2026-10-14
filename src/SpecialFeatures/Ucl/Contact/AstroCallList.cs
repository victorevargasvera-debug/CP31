namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class AstroCallList : FeatureNode
    {
        private AstroCallList();
        internal AstroCallList(Recordset parent);
        protected AstroCallList(SerializationInfo info, StreamingContext context);
        public static IAcpFeatureNode GetAstroCallList();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        internal bool IsDefaultNode();

        public AstroCallListCallListSection CallListAstro { get; }

        public override string ReferenceKey { get; }
    }
}

