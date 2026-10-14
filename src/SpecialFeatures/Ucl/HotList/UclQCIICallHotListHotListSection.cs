namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class UclQCIICallHotListHotListSection : FeatureSection
    {
        private SpecialFeatures.Ucl.HotList.QCIICallHotListRecset qCIICallHotListRecset;
        private AcpKeyField hotListAlias;

        public UclQCIICallHotListHotListSection(FeatureNode parent);
        internal UclQCIICallHotListHotListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        internal string HotListAlias { get; set; }

        public AcpKeyField HotListAliasObject { get; }

        internal string HotListAlias_UILabel { get; }

        public bool HotListAlias_Applicable { get; set; }

        public bool HotListAlias_Editable { get; set; }

        public bool HotListAlias_Visible { get; set; }

        internal bool HotListAlias_HiddenStatic { get; set; }

        public bool HotListAlias_Valid { get; set; }

        public SpecialFeatures.Ucl.HotList.QCIICallHotListRecset QCIICallHotListRecset { get; }
    }
}

