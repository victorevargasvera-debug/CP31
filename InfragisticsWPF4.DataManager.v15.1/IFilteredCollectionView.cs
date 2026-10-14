using System;

namespace Infragistics
{
	// Token: 0x0200003A RID: 58
	public interface IFilteredCollectionView
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600029D RID: 669
		bool CanFilter { get; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600029E RID: 670
		global::Infragistics.RecordFilterCollection FilterConditions { get; }
	}
}
