namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclPhoneCallHotList : FeatureNode
    {
        internal UclPhoneCallHotList(Recordset parent);
        protected UclPhoneCallHotList(SerializationInfo info, StreamingContext context);

        public UclPhoneCallHotListHotListSection PhoneCallHotList { get; }
    }
}

