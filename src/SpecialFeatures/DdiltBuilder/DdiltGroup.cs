namespace SpecialFeatures.DdiltBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct DdiltGroup
    {
        public ushort PartitionNum;
        public ushort NumberTableEntries;
        public ushort Reserved;
        public ushort FirstSingleInstance;
        public ushort LastSingleInstance;
        public SortedDictionary<ushort, ushort> MultiInstanceEntries;
    }
}

