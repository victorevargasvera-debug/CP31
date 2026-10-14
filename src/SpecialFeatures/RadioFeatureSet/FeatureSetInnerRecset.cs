namespace SpecialFeatures.RadioFeatureSet
{
    using SpecialFeatures.Flashport;
    using System;

    public class FeatureSetInnerRecset : Recordset
    {
        public FeatureSetInnerRecset();
        public override FeatureNode CreateDefaultRecord();
        internal void SetValues();

        public override int Max { get; }
    }
}

