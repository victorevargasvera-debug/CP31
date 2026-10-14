namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class PhoneCallHotList : FeatureNode
    {
        private PhoneCallHotList();
        internal PhoneCallHotList(Recordset parent);
        protected PhoneCallHotList(SerializationInfo info, StreamingContext context);
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        internal static IAcpFeatureNode GetPhoneCallHotList();

        public PhoneCallHotListHotListSection HotListPhone { get; }
    }
}

