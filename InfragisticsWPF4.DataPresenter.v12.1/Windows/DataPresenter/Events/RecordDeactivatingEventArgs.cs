using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000294 RID: 660
	public class RecordDeactivatingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001E07 RID: 7687 RVA: 0x00081599 File Offset: 0x0007F799
		internal RecordDeactivatingEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x000815A8 File Offset: 0x0007F7A8
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EC6 RID: 3782
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
