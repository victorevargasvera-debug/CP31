using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000296 RID: 662
	public class RecordExpandingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001E0B RID: 7691 RVA: 0x000815C7 File Offset: 0x0007F7C7
		internal RecordExpandingEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x000815D6 File Offset: 0x0007F7D6
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EC8 RID: 3784
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
