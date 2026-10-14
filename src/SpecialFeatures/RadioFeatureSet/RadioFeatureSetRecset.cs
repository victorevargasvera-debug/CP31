namespace SpecialFeatures.RadioFeatureSet
{
    using SpecialFeatures.Flashport;
    using System;

    public class RadioFeatureSetRecset : Recordset
    {
        public RadioFeatureSetRecset();
        public override FeatureNode CreateDefaultRecord();
        internal void SetValues();
    }
}

