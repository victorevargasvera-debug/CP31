namespace SpecialFeatures.RadioFeatureSet
{
    using SpecialFeatures.Flashport;
    using System;

    public class RadioFeatureSet : FeatureNode
    {
        internal RadioFeatureSet(Recordset parent);

        public SpecialFeatures.RadioFeatureSet.FeatureSet FeatureSet { get; }

        public SpecialFeatures.RadioFeatureSet.General General { get; }

        public SpecialFeatures.RadioFeatureSet.ExtendedFeatureSet ExtendedFeatureSet { get; }
    }
}

