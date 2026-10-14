namespace SpecialFeatures.Flashport.RadioConfiguration
{
    using SpecialFeatures.Flashport;
    using System;

    public class RadioConfiguration : FeatureNode
    {
        internal RadioConfiguration(Recordset parent);

        public SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationFeatures RadioConfigurationFeatures { get; }

        public SpecialFeatures.Flashport.RadioConfiguration.General General { get; }
    }
}

