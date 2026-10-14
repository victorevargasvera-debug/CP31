namespace SpecialFeatures.Flashport.RadioConfiguration
{
    using SpecialFeatures.Flashport;
    using System;

    public sealed class RadioConfigurationFeaturesInnerSection : FeatureSection
    {
        private Field a;
        private Field b;

        internal RadioConfigurationFeaturesInnerSection(FeatureNode parent);
        private void a();
        public override void Init();

        public string RadioConfigFeatureNameValue { get; set; }

        public Field RadioConfigFeatureName { get; }

        public bool RadioConfigFeatureName_Applicable { get; }

        public bool RadioConfigFeatureName_Valid { get; }

        public bool RadioConfigFeatureName_Visible { get; set; }

        public bool RadioConfigFeatureName_Editable { get; }

        internal string RadioConfigFeatureName_UILabel { get; }

        public string RadioConfigCurrentFlashcodeValueValue { get; set; }

        public Field RadioConfigCurrentFlashcodeValue { get; }

        public bool RadioConfigCurrentFlashcodeValue_Applicable { get; }

        public bool RadioConfigCurrentFlashcodeValue_Valid { get; }

        public bool RadioConfigCurrentFlashcodeValue_Visible { get; set; }

        public bool RadioConfigCurrentFlashcodeValue_Editable { get; }

        internal string RadioConfigCurrentFlashcodeValue_UILabel { get; }
    }
}

