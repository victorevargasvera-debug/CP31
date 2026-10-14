namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class QCIICallHotList : FeatureNode
    {
        private QCIICallHotList();
        internal QCIICallHotList(Recordset parent);
        protected QCIICallHotList(SerializationInfo info, StreamingContext context);
        public override void GetObjectData(SerializationInfo info, StreamingContext context);

        public QCIICallHotListHotListSection HotListQCII { get; }
    }
}

