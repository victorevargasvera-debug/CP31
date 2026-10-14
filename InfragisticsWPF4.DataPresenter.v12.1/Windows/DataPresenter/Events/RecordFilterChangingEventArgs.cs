using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000298 RID: 664
	public class RecordFilterChangingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001E0F RID: 7695 RVA: 0x000815F5 File Offset: 0x0007F7F5
		internal RecordFilterChangingEventArgs(global::Infragistics.Windows.DataPresenter.RecordFilter newRecordFilter)
		{
			this._newRecordFilter = newRecordFilter;
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x00081604 File Offset: 0x0007F804
		public global::Infragistics.Windows.DataPresenter.RecordFilter NewRecordFilter
		{
			get
			{
				return this._newRecordFilter;
			}
		}

		// Token: 0x04000ECA RID: 3786
		private global::Infragistics.Windows.DataPresenter.RecordFilter _newRecordFilter;
	}
}
