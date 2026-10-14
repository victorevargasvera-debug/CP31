namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using SpecialFeatures.Ucl.Contact;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class AstroCallHotListHotListSection : FeatureSection
    {
        private AcpRecRefField uclAstroCnvHotList_ContactAlias_A00043;
        private AcpRecRefField uclAstroCnvHotList_CallID_A00044;

        internal AstroCallHotListHotListSection(FeatureNode parent);
        internal AstroCallHotListHotListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public int UclAstroCnvHotList_ContactAlias_A00043Value { get; set; }

        public AcpRecRefField UclAstroCnvHotList_ContactAlias_A00043Object { get; set; }

        public string UclAstroCnvHotList_ContactAlias_A00043_UIValue { get; set; }

        public bool UclAstroCnvHotList_ContactAlias_A00043_Applicable { get; set; }

        public bool UclAstroCnvHotList_ContactAlias_A00043_Editable { get; set; }

        public bool UclAstroCnvHotList_ContactAlias_A00043_Visible { get; set; }

        public bool UclAstroCnvHotList_ContactAlias_A00043_Valid { get; set; }

        public bool UclAstroCnvHotList_ContactAlias_A00043_HasDiffs { get; }

        public int UclAstroCnvHotList_CallID_A00044Value { get; set; }

        public AcpRecRefField UclAstroCnvHotList_CallID_A00044Object { get; set; }

        public string UclAstroCnvHotList_CallID_A00044_UIValue { get; set; }

        public bool UclAstroCnvHotList_CallID_A00044_Applicable { get; set; }

        public bool UclAstroCnvHotList_CallID_A00044_Editable { get; set; }

        public bool UclAstroCnvHotList_CallID_A00044_Visible { get; set; }

        public bool UclAstroCnvHotList_CallID_A00044_Valid { get; set; }

        public bool UclAstroCnvHotList_CallID_A00044_HasDiffs { get; }

        public UclContact Contact { get; }

        public bool HasDiffs { get; }
    }
}

