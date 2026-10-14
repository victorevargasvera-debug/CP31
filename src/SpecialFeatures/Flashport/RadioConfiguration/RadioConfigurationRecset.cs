namespace SpecialFeatures.Flashport.RadioConfiguration
{
    using SpecialFeatures.Flashport;
    using System;

    public class RadioConfigurationRecset : Recordset
    {
        public RadioConfigurationRecset();
        public override FeatureNode CreateDefaultRecord();
        internal void SetValues();
    }
}

