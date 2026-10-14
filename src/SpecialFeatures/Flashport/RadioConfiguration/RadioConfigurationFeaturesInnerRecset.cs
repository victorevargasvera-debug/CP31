namespace SpecialFeatures.Flashport.RadioConfiguration
{
    using SpecialFeatures.Flashport;
    using System;

    public class RadioConfigurationFeaturesInnerRecset : Recordset
    {
        public RadioConfigurationFeaturesInnerRecset();
        public override FeatureNode CreateDefaultRecord();
        internal void SetValues();

        public override int Max { get; }
    }
}

