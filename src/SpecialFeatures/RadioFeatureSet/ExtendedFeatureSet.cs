namespace SpecialFeatures.RadioFeatureSet
{
    using SpecialFeatures.Flashport;
    using System;

    public sealed class ExtendedFeatureSet : FeatureSection
    {
        private ExtendedFeatureSetInnerRecset a;

        internal ExtendedFeatureSet(FeatureNode parent);
        public override void Init();

        public bool IsVisible_EmbeddedRecset { get; }
    }
}

