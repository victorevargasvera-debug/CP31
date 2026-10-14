using System;

namespace Infragistics
{
	// Token: 0x0200003C RID: 60
	internal interface IPagedCollectionView
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002A2 RID: 674
		bool CanChangePage { get; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002A3 RID: 675
		bool IsPageChanging { get; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002A4 RID: 676
		int ItemCount { get; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002A5 RID: 677
		int PageIndex { get; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002A6 RID: 678
		// (set) Token: 0x060002A7 RID: 679
		int PageSize { get; set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002A8 RID: 680
		int TotalItemCount { get; }

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060002A9 RID: 681
		// (remove) Token: 0x060002AA RID: 682
		event global::System.EventHandler<global::System.EventArgs> PageChanged;

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060002AB RID: 683
		// (remove) Token: 0x060002AC RID: 684
		event global::System.EventHandler<global::Infragistics.PageChangingEventArgs> PageChanging;

		// Token: 0x060002AD RID: 685
		bool MoveToFirstPage();

		// Token: 0x060002AE RID: 686
		bool MoveToLastPage();

		// Token: 0x060002AF RID: 687
		bool MoveToNextPage();

		// Token: 0x060002B0 RID: 688
		bool MoveToPage(int pageIndex);

		// Token: 0x060002B1 RID: 689
		bool MoveToPreviousPage();
	}
}
