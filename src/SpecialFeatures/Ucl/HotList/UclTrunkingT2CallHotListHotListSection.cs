namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class UclTrunkingT2CallHotListHotListSection : FeatureSection
    {
        private SpecialFeatures.Ucl.HotList.TrunkingT2CallHotListRecset trunkingT2CallHotListRecset;
        private AcpKeyField uclT2TrkHotList_HotListAlias_A00039;

        internal UclTrunkingT2CallHotListHotListSection(FeatureNode parent);
        internal UclTrunkingT2CallHotListHotListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public string UclT2TrkHotList_HotListAlias_A00039Value { get; set; }

        public AcpKeyField UclT2TrkHotList_HotListAlias_A00039Object { get; }

        internal string UclT2TrkHotList_HotListAlias_A00039_UILabel { get; }

        public bool UclT2TrkHotList_HotListAlias_A00039_Applicable { get; set; }

        public bool UclT2TrkHotList_HotListAlias_A00039_Editable { get; set; }

        public bool UclT2TrkHotList_HotListAlias_A00039_Visible { get; set; }

        internal bool UclT2TrkHotList_HotListAlias_A00039_HiddenStatic { get; set; }

        public bool UclT2TrkHotList_HotListAlias_A00039_Valid { get; set; }

        public bool UclT2TrkHotList_HotListAlias_A00039_HasDiffs { get; }

        internal SpecialFeatures.Ucl.HotList.TrunkingT2CallHotListRecset TrunkingT2CallHotListRecset { get; }

        public bool HasDiffs { get; }
    }
}

