using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200011B RID: 283
	public interface IExportOptions
	{
		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060010EC RID: 4332
		bool ExcludeExpandedState { get; }

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060010ED RID: 4333
		bool ExcludeFieldLayoutSettings { get; }

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060010EE RID: 4334
		bool ExcludeFieldSettings { get; }

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060010EF RID: 4335
		bool ExcludeGroupBySettings { get; }

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060010F0 RID: 4336
		bool ExcludeRecordFilters { get; }

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060010F1 RID: 4337
		bool ExcludeRecordVisibility { get; }

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060010F2 RID: 4338
		bool ExcludeSortOrder { get; }

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060010F3 RID: 4339
		bool ExcludeSummaries { get; }
	}
}
