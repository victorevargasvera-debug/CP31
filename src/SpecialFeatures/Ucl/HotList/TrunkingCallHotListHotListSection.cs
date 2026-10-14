namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using SpecialFeatures.Ucl.Contact;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class TrunkingCallHotListHotListSection : FeatureSection
    {
        private AcpRecRefField uclAstro25TrkHotList_ContactAlias_A00037;
        private AcpRecRefField uclAstro25TrkHotList_CallID_a00038;

        internal TrunkingCallHotListHotListSection(FeatureNode parent);
        internal TrunkingCallHotListHotListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public int UclAstro25TrkHotList_ContactAlias_A00037Value { get; set; }

        public AcpRecRefField UclAstro25TrkHotList_ContactAlias_A00037Object { get; set; }

        public string UclAstro25TrkHotList_ContactAlias_A00037_UIValue { get; set; }

        public bool UclAstro25TrkHotList_ContactAlias_A00037_Applicable { get; set; }

        public bool UclAstro25TrkHotList_ContactAlias_A00037_Editable { get; set; }

        public bool UclAstro25TrkHotList_ContactAlias_A00037_Visible { get; set; }

        public bool UclAstro25TrkHotList_ContactAlias_A00037_Valid { get; set; }

        public bool UclAstro25TrkHotList_ContactAlias_A00037_HasDiffs { get; }

        public int UclAstro25TrkHotList_CallID_a00038Value { get; set; }

        public AcpRecRefField UclAstro25TrkHotList_CallID_a00038Object { get; set; }

        public string UclAstro25TrkHotList_CallID_a00038_UIValue { get; set; }

        public bool UclAstro25TrkHotList_CallID_a00038_Applicable { get; set; }

        public bool UclAstro25TrkHotList_CallID_a00038_Editable { get; set; }

        public bool UclAstro25TrkHotList_CallID_a00038_Visible { get; set; }

        public bool UclAstro25TrkHotList_CallID_a00038_Valid { get; set; }

        public bool UclAstro25TrkHotList_CallID_a00038_HasDiffs { get; }

        public UclContact Contact { get; }

        public bool HasDiffs { get; }
    }
}

