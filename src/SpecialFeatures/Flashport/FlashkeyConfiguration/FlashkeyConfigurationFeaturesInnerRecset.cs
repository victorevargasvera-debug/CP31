namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
    using SpecialFeatures.Flashport;
    using System;

    public class FlashkeyConfigurationFeaturesInnerRecset : Recordset
    {
        public FlashkeyConfigurationFeaturesInnerRecset();
        public override FeatureNode CreateDefaultRecord();
        internal void SetValues();

        public override int Max { get; }
    }
}

