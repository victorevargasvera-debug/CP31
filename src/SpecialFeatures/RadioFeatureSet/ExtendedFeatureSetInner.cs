namespace SpecialFeatures.RadioFeatureSet
{
    using SpecialFeatures.Flashport;
    using System;

    public class ExtendedFeatureSetInner : FeatureNode
    {
        internal ExtendedFeatureSetInner(Recordset parent);

        public SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInnerSection ExtendedFeatureSetInnerSection { get; }
    }
}

