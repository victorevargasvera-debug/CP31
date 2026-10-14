namespace SpecialFeatures.Flashport.RadioConfiguration
{
    using SpecialFeatures.Flashport;
    using System;

    public sealed class RadioConfigurationFeatures : FeatureSection
    {
        private RadioConfigurationFeaturesInnerRecset a;
        private bool b;

        internal RadioConfigurationFeatures(FeatureNode parent);
        private void a();
        public override void Init();

        public bool IsVisible { get; set; }
    }
}

