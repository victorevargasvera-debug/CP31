namespace SpecialFeatures.FCCExceptionHandler
{
    using System;
    using System.Collections.Generic;

    internal class RangeSection : BaseSection
    {
        private List<FreqRange> a;

        internal RangeSection();
        internal void AddRange(FreqRange r);

        public List<FreqRange> RangesList { get; }
    }
}

