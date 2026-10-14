namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
    using SpecialFeatures.Flashport;
    using System;

    public class FlashkeyConfigurationRecset : Recordset
    {
        public FlashkeyConfigurationRecset();
        public override FeatureNode CreateDefaultRecord();
        internal void SetValues();
    }
}

