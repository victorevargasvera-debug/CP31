namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class UclContactMDCCallListSection : FeatureSection
    {
        private SpecialFeatures.Ucl.Contact.MDCCallListRecset mdcCallListRecset;

        internal UclContactMDCCallListSection(FeatureNode parent);
        internal UclContactMDCCallListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        internal SpecialFeatures.Ucl.Contact.MDCCallListRecset MDCCallListRecset { get; }

        public bool HasDiffs { get; }
    }
}

