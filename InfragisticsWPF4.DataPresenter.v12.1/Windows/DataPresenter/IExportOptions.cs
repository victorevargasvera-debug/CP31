using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000FF RID: 255
	public interface IExportOptions
	{
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000D8B RID: 3467
		bool ExcludeExpandedState { get; }

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000D8C RID: 3468
		bool ExcludeFieldLayoutSettings { get; }

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000D8D RID: 3469
		bool ExcludeFieldSettings { get; }

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000D8E RID: 3470
		bool ExcludeGroupBySettings { get; }

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000D8F RID: 3471
		bool ExcludeRecordFilters { get; }

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000D90 RID: 3472
		bool ExcludeRecordVisibility { get; }

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000D91 RID: 3473
		bool ExcludeSortOrder { get; }

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000D92 RID: 3474
		bool ExcludeSummaries { get; }
	}
}
