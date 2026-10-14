namespace SpecialFeatures.DdiltBuilder
{
    using System;
    using System.Collections.Generic;

    public class DDILTComparer : IComparer<ushort>
    {
        public DDILTComparer();
        public int Compare(ushort x, ushort y);
    }
}

