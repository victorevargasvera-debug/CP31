using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000CB RID: 203
	public interface IViewPanelInfo
	{
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000967 RID: 2407
		int OverallScrollCount { get; }

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000968 RID: 2408
		// (set) Token: 0x06000969 RID: 2409
		int OverallScrollPosition { get; set; }

		// Token: 0x0600096A RID: 2410
		int GetOverallScrollPositionForRecord(global::Infragistics.Windows.DataPresenter.Record record);

		// Token: 0x0600096B RID: 2411
		global::Infragistics.Windows.DataPresenter.Record GetRecordAtOverallScrollPosition(int scrollPosition);

		// Token: 0x0600096C RID: 2412
		bool IsOkToScroll();

		// Token: 0x0600096D RID: 2413
		void OnRecordsInViewChanged();
	}
}
