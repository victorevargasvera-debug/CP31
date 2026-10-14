namespace SpecialFeatures.RadioFeatureSet
{
    using SpecialFeatures.Flashport;
    using System;

    public sealed class General : FeatureSection
    {
        private Field a;
        private Field b;

        internal General(FeatureNode parent);
        private void a();
        public override void Init();

        public string FeatureSetGeneralPurchasedFLASHcodeValue { get; set; }

        public Field FeatureSetGeneralPurchasedFLASHcode { get; }

        public string FeatureSetGeneralPurchasedFLASHcode_UIValue { get; set; }

        public bool FeatureSetGeneralPurchasedFLASHcode_Applicable { get; }

        public bool FeatureSetGeneralPurchasedFLASHcode_Valid { get; }

        public bool FeatureSetGeneralPurchasedFLASHcode_Visible { get; }

        public bool FeatureSetGeneralPurchasedFLASHcode_Editable { get; }

        public string FeatureSetGeneralPurchasedFLASHcode_UILabel { get; }

        public string FeatureSetGeneralUsedFLASHcodeValue { get; set; }

        public Field FeatureSetGeneralUsedFLASHcode { get; }

        public string FeatureSetGeneralUsedFLASHcode_UIValue { get; set; }

        public bool FeatureSetGeneralUsedFLASHcode_Applicable { get; }

        public bool FeatureSetGeneralUsedFLASHcode_Valid { get; }

        public bool FeatureSetGeneralUsedFLASHcode_Visible { get; }

        public bool FeatureSetGeneralUsedFLASHcode_Editable { get; }

        public string FeatureSetGeneralUsedFLASHcode_UILabel { get; }
    }
}

