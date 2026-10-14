namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class UclAstroCallHotListHotListSection : FeatureSection
    {
        private SpecialFeatures.Ucl.HotList.AstroCallHotListRecset astroCallHotListRecset;
        private AcpKeyField uclAstroCnvHotList_HotListAlias_A00042;

        internal UclAstroCallHotListHotListSection(FeatureNode parent);
        internal UclAstroCallHotListHotListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public string UclAstroCnvHotList_HotListAlias_A00042Value { get; set; }

        public AcpKeyField UclAstroCnvHotList_HotListAlias_A00042Object { get; }

        internal string UclAstroCnvHotList_HotListAlias_A00042_UILabel { get; }

        public bool UclAstroCnvHotList_HotListAlias_A00042_Applicable { get; set; }

        public bool UclAstroCnvHotList_HotListAlias_A00042_Editable { get; set; }

        public bool UclAstroCnvHotList_HotListAlias_A00042_Visible { get; set; }

        internal bool UclAstroCnvHotList_HotListAlias_A00042_HiddenStatic { get; set; }

        public bool UclAstroCnvHotList_HotListAlias_A00042_Valid { get; set; }

        public bool UclAstroCnvHotList_HotListAlias_A00042_HasDiffs { get; }

        public SpecialFeatures.Ucl.HotList.AstroCallHotListRecset AstroCallHotListRecset { get; }

        public bool HasDiffs { get; }
    }
}

