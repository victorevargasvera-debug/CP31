using System;

namespace Infragistics.Collections
{
	// Token: 0x02000014 RID: 20
	public interface ISparseArrayMultiItem : global::Infragistics.Collections.ISparseArrayItem
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000EF RID: 239
		int ScrollCount { get; }

		// Token: 0x060000F0 RID: 240
		object GetItemAtScrollIndex(int scrollIndex);
	}
}
