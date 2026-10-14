namespace SpecialFeatures.Ucl.UclWide
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclWideRecset : Recordset
    {
        public UclWideRecset();
        protected UclWideRecset(SerializationInfo info, StreamingContext context);
        private void a();
        public override FeatureNode CreateDefaultRecord();

        public bool HasDiffs { get; }
    }
}

