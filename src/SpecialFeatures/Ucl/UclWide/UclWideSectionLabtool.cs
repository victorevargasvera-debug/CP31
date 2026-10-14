namespace SpecialFeatures.Ucl.UclWide
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class UclWideSectionLabtool : FeatureSection
    {
        private AcpField<int> uclWideLab_MaxContacts_A00006;
        private AcpField<int> uclWideLab_ContactsCombinedDataMax_A00007;
        private AcpField<int> uclWideLab_MaxHotlistContacts_A00008;

        internal UclWideSectionLabtool(FeatureNode parent);
        internal UclWideSectionLabtool(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public int UclWideLab_MaxContacts_A00006Value { get; set; }

        public AcpField<int> UclWideLab_MaxContacts_A00006Object { get; }

        public bool UclWideLab_MaxContacts_A00006_Applicable { get; set; }

        public bool UclWideLab_MaxContacts_A00006_Valid { get; set; }

        public bool UclWideLab_MaxContacts_A00006_HasDiffs { get; }

        public bool UclWideLab_MaxContacts_A00006_Visible { get; set; }

        public bool UclWideLab_MaxContacts_A00006_Editable { get; set; }

        public string UclWideLab_MaxContacts_A00006_UILabel { get; }

        internal bool UclWideLab_MaxContacts_A00006_HiddenStatic { get; set; }

        internal bool UclWideLab_MaxContacts_A00006_HiddenDynamic { get; set; }

        public int UclWideLab_ContactsCombinedDataMax_A00007Value { get; set; }

        public AcpField<int> UclWideLab_ContactsCombinedDataMax_A00007Object { get; }

        public bool UclWideLab_ContactsCombinedDataMax_A00007_Applicable { get; set; }

        public bool UclWideLab_ContactsCombinedDataMax_A00007_Valid { get; set; }

        public bool UclWideLab_ContactsCombinedDataMax_A00007_HasDiffs { get; }

        public bool UclWideLab_ContactsCombinedDataMax_A00007_Visible { get; set; }

        public bool UclWideLab_ContactsCombinedDataMax_A00007_Editable { get; set; }

        public string UclWideLab_ContactsCombinedDataMax_A00007_UILabel { get; }

        internal bool UclWideLab_ContactsCombinedDataMax_A00007_HiddenStatic { get; set; }

        internal bool UclWideLab_ContactsCombinedDataMax_A00007_HiddenDynamic { get; set; }

        public int UclWideLab_MaxHotlistContacts_A00008Value { get; set; }

        public AcpField<int> UclWideLab_MaxHotlistContacts_A00008Object { get; }

        public bool UclWideLab_MaxHotlistContacts_A00008_Applicable { get; set; }

        public bool UclWideLab_MaxHotlistContacts_A00008_Valid { get; set; }

        public bool UclWideLab_MaxHotlistContacts_A00008_HasDiffs { get; }

        public bool UclWideLab_MaxHotlistContacts_A00008_Visible { get; set; }

        public bool UclWideLab_MaxHotlistContacts_A00008_Editable { get; set; }

        public string UclWideLab_MaxHotlistContacts_A00008_UILabel { get; }

        internal bool UclWideLab_MaxHotlistContacts_A00008_HiddenStatic { get; set; }

        internal bool UclWideLab_MaxHotlistContacts_A00008_HiddenDynamic { get; set; }

        public bool HasDiffs { get; }
    }
}

