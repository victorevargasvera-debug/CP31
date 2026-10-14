namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using SpecialFeatures.Ucl.Contact;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class MDCCallHotListHotListSection : FeatureSection
    {
        private AcpRecRefField uclMDCCnvHotList_ContactAlias_A00046;
        private AcpRecRefField uclMDCCnvHotList_CallID_A00047;

        internal MDCCallHotListHotListSection(FeatureNode parent);
        internal MDCCallHotListHotListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public int UclMDCCnvHotList_ContactAlias_A00046Value { get; set; }

        public AcpRecRefField UclMDCCnvHotList_ContactAlias_A00046Object { get; set; }

        public string UclMDCCnvHotList_ContactAlias_A00046_UIValue { get; set; }

        public bool UclMDCCnvHotList_ContactAlias_A00046_Applicable { get; set; }

        public bool UclMDCCnvHotList_ContactAlias_A00046_Editable { get; set; }

        public bool UclMDCCnvHotList_ContactAlias_A00046_Visible { get; set; }

        public bool UclMDCCnvHotList_ContactAlias_A00046_Valid { get; set; }

        public bool UclMDCCnvHotList_ContactAlias_A00046_HasDiffs { get; }

        public int UclMDCCnvHotList_CallID_A00047Value { get; set; }

        public AcpRecRefField UclMDCCnvHotList_CallID_A00047Object { get; set; }

        public string UclMDCCnvHotList_CallID_A00047_UIValue { get; set; }

        public bool UclMDCCnvHotList_CallID_A00047_Applicable { get; set; }

        public bool UclMDCCnvHotList_CallID_A00047_Editable { get; set; }

        public bool UclMDCCnvHotList_CallID_A00047_Visible { get; set; }

        public bool UclMDCCnvHotList_CallID_A00047_Valid { get; set; }

        public bool UclMDCCnvHotList_CallID_A00047_HasDiffs { get; }

        public UclContact Contact { get; }

        public bool HasDiffs { get; }
    }
}

