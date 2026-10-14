namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class QCIICallListRecset : Recordset
    {
        internal QCIICallListRecset();
        protected QCIICallListRecset(SerializationInfo info, StreamingContext context);
        public override FeatureNode CreateDefaultRecord();
    }
}

