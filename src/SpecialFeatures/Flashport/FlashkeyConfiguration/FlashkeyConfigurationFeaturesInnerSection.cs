namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
    using SpecialFeatures.Flashport;
    using System;

    public sealed class FlashkeyConfigurationFeaturesInnerSection : FeatureSection
    {
        private Field a;
        private Field b;
        private Field c;

        internal FlashkeyConfigurationFeaturesInnerSection(FeatureNode parent);
        private void a();
        public override void Init();

        public string FkeyConfigFeatureNameValue { get; set; }

        public Field FkeyConfigFeatureName { get; }

        public bool FkeyConfigFeatureName_Applicable { get; }

        public bool FkeyConfigFeatureName_Valid { get; }

        public bool FkeyConfigFeatureName_Visible { get; set; }

        public bool FkeyConfigFeatureName_Editable { get; }

        public string FkeyConfigFeatureName_UILabel { get; }

        public string FkeyConfigCurrentFlashcodeValueValue { get; set; }

        public Field FkeyConfigCurrentFlashcodeValue { get; }

        public bool FkeyConfigCurrentFlashcodeValue_Applicable { get; }

        public bool FkeyConfigCurrentFlashcodeValue_Valid { get; }

        public bool FkeyConfigCurrentFlashcodeValue_Visible { get; set; }

        public bool FkeyConfigCurrentFlashcodeValue_Editable { get; }

        public string FkeyConfigCurrentFlashcodeValue_UILabel { get; }

        public string FkeyConfigNewFlashcodeValueValue { get; set; }

        public Field FkeyConfigNewFlashcodeValue { get; }

        public bool FkeyConfigNewFlashcodeValue_Applicable { get; }

        public bool FkeyConfigNewFlashcodeValue_Valid { get; }

        public bool FkeyConfigNewFlashcodeValue_Visible { get; set; }

        public bool FkeyConfigNewFlashcodeValue_Editable { get; }

        public string FkeyConfigNewFlashcodeValue_UILabel { get; }
    }
}

