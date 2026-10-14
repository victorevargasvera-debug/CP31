namespace SpecialFeatures.FCCExceptionHandler
{
    using System;
    using System.Collections.Generic;

    internal class PointSection : BaseSection
    {
        private List<string> a;

        internal PointSection();
        internal void AddPoint(string point);

        public List<string> PointsList { get; }
    }
}

