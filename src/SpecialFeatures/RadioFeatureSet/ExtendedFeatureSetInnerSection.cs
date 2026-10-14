namespace SpecialFeatures.RadioFeatureSet
{
    using SpecialFeatures.Flashport;
    using System;
    using System.Runtime.CompilerServices;

    public sealed class ExtendedFeatureSetInnerSection : FeatureSection
    {
        private bool a;
        [CompilerGenerated]
        private bool b;
        private Field c;
        private Field d;

        internal ExtendedFeatureSetInnerSection(FeatureNode parent);
        private void a();
        public override void Init();

        public bool ExtendedFeatureSetEnabled_boolValue { get; set; }

        internal bool IsUseforPermanentExcised { get; set; }

        public string ExtendedFeatureSetFeatureNameValue { get; set; }

        public Field ExtendedFeatureSetFeatureName { get; }

        public string ExtendedFeatureSetFeatureName_UIValue { get; set; }

        public bool ExtendedFeatureSetFeatureName_Applicable { get; }

        public bool ExtendedFeatureSetFeatureName_Valid { get; }

        public bool ExtendedFeatureSetFeatureName_Visible { get; }

        public bool ExtendedFeatureSetFeatureName_Editable { get; }

        internal string ExtendedFeatureSetFeatureName_UILabel { get; }

        public string ExtendedFeatureSetEnabledValue { get; set; }

        public Field ExtendedFeatureSetEnabled { get; }

        public string ExtendedFeatureSetEnabled_UIValue { get; set; }

        public bool ExtendedFeatureSetEnabled_Applicable { get; }

        public bool ExtendedFeatureSetEnabled_Valid { get; }

        public bool ExtendedFeatureSetEnabled_Visible { get; }

        public bool ExtendedFeatureSetEnabled_Editable { get; }

        internal string ExtendedFeatureSetEnabled_UILabel { get; }

        public bool ExtendedFeature_Visible { get; }
    }
}

