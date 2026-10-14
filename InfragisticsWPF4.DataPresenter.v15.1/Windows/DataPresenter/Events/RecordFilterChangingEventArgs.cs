using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002DB RID: 731
	public class RecordFilterChangingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06002297 RID: 8855 RVA: 0x00097D89 File Offset: 0x00095F89
		internal RecordFilterChangingEventArgs(global::Infragistics.Windows.DataPresenter.RecordFilter newRecordFilter)
		{
			this._newRecordFilter = newRecordFilter;
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x00097D98 File Offset: 0x00095F98
		public global::Infragistics.Windows.DataPresenter.RecordFilter NewRecordFilter
		{
			get
			{
				return this._newRecordFilter;
			}
		}

		// Token: 0x04001134 RID: 4404
		private global::Infragistics.Windows.DataPresenter.RecordFilter _newRecordFilter;
	}
}
