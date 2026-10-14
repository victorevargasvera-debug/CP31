namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class UclContactAstroCallListSection : FeatureSection
    {
        private SpecialFeatures.Ucl.Contact.AstroCallListRecset astroCallListRecset;

        internal UclContactAstroCallListSection(FeatureNode parent);
        internal UclContactAstroCallListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        internal SpecialFeatures.Ucl.Contact.AstroCallListRecset AstroCallListRecset { get; }

        public bool HasDiffs { get; }
    }
}

