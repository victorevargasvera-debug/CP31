namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
    using SpecialFeatures.Flashport;
    using System;

    public class FlashkeyConfiguration : FeatureNode
    {
        internal FlashkeyConfiguration(Recordset parent);

        public SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationFeatures FlashkeyConfigurationFeatures { get; }

        public SpecialFeatures.Flashport.FlashkeyConfiguration.General General { get; }
    }
}

