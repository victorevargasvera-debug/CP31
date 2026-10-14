namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class UclContactGeneralSection : FeatureSection
    {
        private AcpKeyField uclGen_ContactAlias_A00009;

        internal UclContactGeneralSection(FeatureNode parent);
        internal UclContactGeneralSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu RefDisplayAndMenu { get; }

        public bool HasDiffs { get; }

        public string UclGen_ContactAlias_A00009Value { get; set; }

        public AcpKeyField UclGen_ContactAlias_A00009Object { get; }

        public bool UclGen_ContactAlias_A00009_HasDiffs { get; }

        public string UclGen_ContactAlias_A00009_UILabel { get; }

        public bool UclGen_ContactAlias_A00009_Applicable { get; set; }

        public bool UclGen_ContactAlias_A00009_Editable { get; set; }

        public bool UclGen_ContactAlias_A00009_Visible { get; set; }

        internal bool UclGen_ContactAlias_A00009_HiddenStatic { get; set; }

        public bool UclGen_ContactAlias_A00009_Valid { get; set; }
    }
}

