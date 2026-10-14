namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
    using SpecialFeatures.Flashport;
    using System;

    public sealed class FlashkeyConfigurationFeatures : FeatureSection
    {
        private FlashkeyConfigurationFeaturesInnerRecset a;
        private bool b;

        internal FlashkeyConfigurationFeatures(FeatureNode parent);
        private void a();
        public override void Init();

        public bool IsVisible { get; set; }
    }
}

