using System;

namespace Infragistics.Windows.Reporting
{
	// Token: 0x02000204 RID: 516
	public interface IEmbeddedVisualPaginator
	{
		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001331 RID: 4913
		object CurrentPageDataContext { get; }

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001332 RID: 4914
		global::Infragistics.Windows.Reporting.PagePosition CurrentPagePosition { get; }

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001333 RID: 4915
		int EstimatedPageCount { get; }

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001334 RID: 4916
		int LogicalPageNumber { get; }

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001335 RID: 4917
		int LogicalPagePartNumber { get; }

		// Token: 0x06001336 RID: 4918
		void BeginPagination(global::Infragistics.Windows.Reporting.ReportSection section);

		// Token: 0x06001337 RID: 4919
		void EndPagination();

		// Token: 0x06001338 RID: 4920
		bool MoveToNextPage();

		// Token: 0x06001339 RID: 4921
		bool MoveToPosition(global::Infragistics.Windows.Reporting.PagePosition pagePosition);
	}
}
