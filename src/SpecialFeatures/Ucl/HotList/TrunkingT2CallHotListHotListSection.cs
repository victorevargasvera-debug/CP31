namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using SpecialFeatures.Ucl.Contact;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class TrunkingT2CallHotListHotListSection : FeatureSection
    {
        private AcpRecRefField uclT2TrkHotList_ContactAlias_A00040;
        private AcpRecRefField uclT2TrkHotList_CallID_A00041;

        internal TrunkingT2CallHotListHotListSection(FeatureNode parent);
        internal TrunkingT2CallHotListHotListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public int UclT2TrkHotList_ContactAlias_A00040Value { get; set; }

        public AcpRecRefField UclT2TrkHotList_ContactAlias_A00040Object { get; set; }

        public string UclT2TrkHotList_ContactAlias_A00040_UIValue { get; set; }

        public bool UclT2TrkHotList_ContactAlias_A00040_Applicable { get; set; }

        public bool UclT2TrkHotList_ContactAlias_A00040_Editable { get; set; }

        public bool UclT2TrkHotList_ContactAlias_A00040_Visible { get; set; }

        public bool UclT2TrkHotList_ContactAlias_A00040_Valid { get; set; }

        public bool UclT2TrkHotList_ContactAlias_A00040_HasDiffs { get; }

        public int UclT2TrkHotList_CallID_A00041Value { get; set; }

        public AcpRecRefField UclT2TrkHotList_CallID_A00041Object { get; set; }

        public string UclT2TrkHotList_CallID_A00041_UIValue { get; set; }

        public bool UclT2TrkHotList_CallID_A00041_Applicable { get; set; }

        public bool UclT2TrkHotList_CallID_A00041_Editable { get; set; }

        public bool UclT2TrkHotList_CallID_A00041_Visible { get; set; }

        public bool UclT2TrkHotList_CallID_A00041_Valid { get; set; }

        public bool UclT2TrkHotList_CallID_A00041_HasDiffs { get; }

        internal UclContact Contact { get; }

        public bool HasDiffs { get; }
    }
}

