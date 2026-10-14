namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class UclContactPhoneCallListSection : FeatureSection
    {
        private SpecialFeatures.Ucl.Contact.PhoneCallListRecset phoneCallListRecset;

        public UclContactPhoneCallListSection(FeatureNode parent);
        internal UclContactPhoneCallListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public SpecialFeatures.Ucl.Contact.PhoneCallListRecset PhoneCallListRecset { get; }

        public bool HasDiffs { get; }
    }
}

