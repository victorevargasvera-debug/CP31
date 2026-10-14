namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class DTMFCallListRecset : Recordset
    {
        public DTMFCallListRecset();
        protected DTMFCallListRecset(SerializationInfo info, StreamingContext context);
        public override FeatureNode CreateDefaultRecord();
    }
}

