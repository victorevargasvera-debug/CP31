namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclContact : FeatureNode
    {
        internal UclContact(Recordset parent);
        protected UclContact(SerializationInfo info, StreamingContext context);
        protected override void Dispose(bool disposing);
        internal static Recordset GetContactRecset();

        public UclContactGeneralSection General { get; }

        public UclContactTrunkingCallListSection TrunkingCallList { get; }

        public UclContactTrunkingT2CallListSection TrunkingT2CallList { get; }

        public UclContactAstroCallListSection AstroCallList { get; }

        public UclContactMDCCallListSection MDCCallList { get; }

        internal UclContactDTMFCallListSection DTMFCallList { get; }

        internal UclContactQCIICallListSection QCIICallList { get; }

        public UclContactPhoneCallListSection PhoneCallList { get; }
    }
}

