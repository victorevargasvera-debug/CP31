using System;

namespace Infragistics.Windows.Reporting
{
	// Token: 0x020001D6 RID: 470
	public interface IEmbeddedVisualPaginator
	{
		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x0600115F RID: 4447
		object CurrentPageDataContext { get; }

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001160 RID: 4448
		global::Infragistics.Windows.Reporting.PagePosition CurrentPagePosition { get; }

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001161 RID: 4449
		int EstimatedPageCount { get; }

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001162 RID: 4450
		int LogicalPageNumber { get; }

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001163 RID: 4451
		int LogicalPagePartNumber { get; }

		// Token: 0x06001164 RID: 4452
		void BeginPagination(global::Infragistics.Windows.Reporting.ReportSection section);

		// Token: 0x06001165 RID: 4453
		void EndPagination();

		// Token: 0x06001166 RID: 4454
		bool MoveToNextPage();

		// Token: 0x06001167 RID: 4455
		bool MoveToPosition(global::Infragistics.Windows.Reporting.PagePosition pagePosition);
	}
}
