namespace SpecialFeatures.Ucl.UclWide
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclWide : FeatureNode
    {
        private UclWide();
        internal UclWide(Recordset parent);
        protected UclWide(SerializationInfo info, StreamingContext context);
        public override void GetObjectData(SerializationInfo info, StreamingContext context);

        public UclWideSectionGeneral General { get; }

        public UclWideSectionLabtool Labtool { get; }
    }
}

