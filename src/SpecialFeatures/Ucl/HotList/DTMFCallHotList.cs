namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class DTMFCallHotList : FeatureNode
    {
        private DTMFCallHotList();
        internal DTMFCallHotList(Recordset parent);
        protected DTMFCallHotList(SerializationInfo info, StreamingContext context);
        public override void GetObjectData(SerializationInfo info, StreamingContext context);

        public DTMFCallHotListHotListSection HotListDTMF { get; }
    }
}

