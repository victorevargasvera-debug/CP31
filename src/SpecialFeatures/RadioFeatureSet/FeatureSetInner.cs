namespace SpecialFeatures.RadioFeatureSet
{
    using SpecialFeatures.Flashport;
    using System;

    public class FeatureSetInner : FeatureNode
    {
        internal FeatureSetInner(Recordset parent);

        public SpecialFeatures.RadioFeatureSet.FeatureSetInnerSection FeatureSetInnerSection { get; }
    }
}

