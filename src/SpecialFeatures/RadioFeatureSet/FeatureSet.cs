namespace SpecialFeatures.RadioFeatureSet
{
    using SpecialFeatures.Flashport;
    using System;

    public sealed class FeatureSet : FeatureSection
    {
        private FeatureSetInnerRecset a;

        internal FeatureSet(FeatureNode parent);
        public override void Init();
    }
}

