namespace SpecialFeatures.RadioFeatureSet
{
    using SpecialFeatures.Flashport;
    using System;

    public class ExtendedFeatureSetInnerRecset : Recordset
    {
        public ExtendedFeatureSetInnerRecset();
        public override FeatureNode CreateDefaultRecord();
        internal void SetValues();

        public override int Max { get; }
    }
}

