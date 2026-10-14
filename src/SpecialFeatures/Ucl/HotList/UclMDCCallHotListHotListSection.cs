namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class UclMDCCallHotListHotListSection : FeatureSection
    {
        private SpecialFeatures.Ucl.HotList.MDCCallHotListRecset mdcCallHotListRecset;
        private AcpKeyField uclMDCCnvHotList_HotListAlias_A00045;

        internal UclMDCCallHotListHotListSection(FeatureNode parent);
        internal UclMDCCallHotListHotListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public string UclMDCCnvHotList_HotListAlias_A00045Value { get; set; }

        public AcpKeyField UclMDCCnvHotList_HotListAlias_A00045Object { get; }

        internal string UclMDCCnvHotList_HotListAlias_A00045_UILabel { get; }

        public bool UclMDCCnvHotList_HotListAlias_A00045_Applicable { get; set; }

        public bool UclMDCCnvHotList_HotListAlias_A00045_Editable { get; set; }

        public bool UclMDCCnvHotList_HotListAlias_A00045_Visible { get; set; }

        internal bool UclMDCCnvHotList_HotListAlias_A00045_HiddenStatic { get; set; }

        public bool UclMDCCnvHotList_HotListAlias_A00045_Valid { get; set; }

        public bool UclMDCCnvHotList_HotListAlias_A00045_HasDiffs { get; }

        public SpecialFeatures.Ucl.HotList.MDCCallHotListRecset MDCCallHotListRecset { get; }

        public bool HasDiffs { get; }
    }
}

