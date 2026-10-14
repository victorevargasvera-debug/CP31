namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class PhoneCallList : FeatureNode
    {
        private PhoneCallList();
        internal PhoneCallList(Recordset parent);
        protected PhoneCallList(SerializationInfo info, StreamingContext context);
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        internal static IAcpFeatureNode GetPhoneCallList();
        internal bool IsDefaultNode();

        public PhoneCallListCallListSection CallListPhone { get; }

        public override string ReferenceKey { get; }
    }
}

