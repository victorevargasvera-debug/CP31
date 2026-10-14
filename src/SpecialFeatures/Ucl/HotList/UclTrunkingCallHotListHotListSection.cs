namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class UclTrunkingCallHotListHotListSection : FeatureSection
    {
        private SpecialFeatures.Ucl.HotList.TrunkingCallHotListRecset trunkingCallHotListRecset;
        private AcpKeyField uclAstro25TrkHotList_HotListAlias_A00036;

        internal UclTrunkingCallHotListHotListSection(FeatureNode parent);
        internal UclTrunkingCallHotListHotListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public string UclAstro25TrkHotList_HotListAlias_A00036Value { get; set; }

        public AcpKeyField UclAstro25TrkHotList_HotListAlias_A00036Object { get; }

        internal string UclAstro25TrkHotList_HotListAlias_A00036_UILabel { get; }

        public bool UclAstro25TrkHotList_HotListAlias_A00036_Applicable { get; set; }

        public bool UclAstro25TrkHotList_HotListAlias_A00036_Editable { get; set; }

        public bool UclAstro25TrkHotList_HotListAlias_A00036_Visible { get; set; }

        internal bool UclAstro25TrkHotList_HotListAlias_A00036_HiddenStatic { get; set; }

        public bool UclAstro25TrkHotList_HotListAlias_A00036_Valid { get; set; }

        public bool UclAstro25TrkHotList_HotListAlias_A00036_HasDiffs { get; }

        internal SpecialFeatures.Ucl.HotList.TrunkingCallHotListRecset TrunkingCallHotListRecset { get; }

        public bool HasDiffs { get; }
    }
}

