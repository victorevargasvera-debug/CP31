namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class UclContactQCIICallListSection : FeatureSection
    {
        private SpecialFeatures.Ucl.Contact.QCIICallListRecset qCIICallListRecset;

        public UclContactQCIICallListSection(FeatureNode parent);
        internal UclContactQCIICallListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public SpecialFeatures.Ucl.Contact.QCIICallListRecset QCIICallListRecset { get; }
    }
}

