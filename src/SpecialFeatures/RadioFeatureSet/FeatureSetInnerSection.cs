namespace SpecialFeatures.RadioFeatureSet
{
    using SpecialFeatures.Flashport;
    using System;

    public sealed class FeatureSetInnerSection : FeatureSection
    {
        private Field a;
        private Field b;

        internal FeatureSetInnerSection(FeatureNode parent);
        private void a();
        public override void Init();

        public string FeatureSetPurchasedFeatureNameValue { get; set; }

        public Field FeatureSetPurchasedFeatureName { get; }

        public string FeatureSetPurchasedFeatureName_UIValue { get; set; }

        public bool FeatureSetPurchasedFeatureName_Applicable { get; }

        public bool FeatureSetPurchasedFeatureName_Valid { get; }

        public bool FeatureSetPurchasedFeatureName_Visible { get; }

        public bool FeatureSetPurchasedFeatureName_Editable { get; }

        public string FeatureSetPurchasedFeatureName_UILabel { get; }

        public string FeatureSetEnabledInUsedFlashcodeValue { get; set; }

        public Field FeatureSetEnabledInUsedFlashcode { get; }

        public string FeatureSetEnabledInUsedFlashcode_UIValue { get; set; }

        public bool FeatureSetEnabledInUsedFlashcode_Applicable { get; }

        public bool FeatureSetEnabledInUsedFlashcode_Valid { get; }

        public bool FeatureSetEnabledInUsedFlashcode_Visible { get; }

        public bool FeatureSetEnabledInUsedFlashcode_Editable { get; }

        public string FeatureSetEnabledInUsedFlashcode_UILabel { get; }
    }
}

