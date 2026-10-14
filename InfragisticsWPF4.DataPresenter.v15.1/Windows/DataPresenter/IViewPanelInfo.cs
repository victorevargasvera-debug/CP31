using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000E7 RID: 231
	public interface IViewPanelInfo
	{
		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000C9D RID: 3229
		int OverallScrollCount { get; }

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000C9E RID: 3230
		// (set) Token: 0x06000C9F RID: 3231
		int OverallScrollPosition { get; set; }

		// Token: 0x06000CA0 RID: 3232
		int GetOverallScrollPositionForRecord(global::Infragistics.Windows.DataPresenter.Record record);

		// Token: 0x06000CA1 RID: 3233
		global::Infragistics.Windows.DataPresenter.Record GetRecordAtOverallScrollPosition(int scrollPosition);

		// Token: 0x06000CA2 RID: 3234
		bool IsOkToScroll();

		// Token: 0x06000CA3 RID: 3235
		void OnRecordsInViewChanged();
	}
}
