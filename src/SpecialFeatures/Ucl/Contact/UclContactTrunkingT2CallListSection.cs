namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class UclContactTrunkingT2CallListSection : FeatureSection
    {
        private SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trunkingT2CallListRecset;

        internal UclContactTrunkingT2CallListSection(FeatureNode parent);
        internal UclContactTrunkingT2CallListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        internal SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset TrunkingT2CallListRecset { get; }

        public bool HasDiffs { get; }
    }
}

