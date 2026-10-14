using System;
using System.Collections.Generic;

namespace SpecialFeatures.DdiltBuilder
{
	// Token: 0x02000144 RID: 324
	public struct DdiltGroup
	{
		// Token: 0x040008E4 RID: 2276
		public ushort PartitionNum;

		// Token: 0x040008E5 RID: 2277
		public ushort NumberTableEntries;

		// Token: 0x040008E6 RID: 2278
		public ushort Reserved;

		// Token: 0x040008E7 RID: 2279
		public ushort FirstSingleInstance;

		// Token: 0x040008E8 RID: 2280
		public ushort LastSingleInstance;

		// Token: 0x040008E9 RID: 2281
		public global::System.Collections.Generic.SortedDictionary<ushort, ushort> MultiInstanceEntries;
	}
}
