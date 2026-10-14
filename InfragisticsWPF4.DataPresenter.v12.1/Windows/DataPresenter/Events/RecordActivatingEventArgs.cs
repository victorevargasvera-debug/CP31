using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200028F RID: 655
	public class RecordActivatingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001DFD RID: 7677 RVA: 0x00081526 File Offset: 0x0007F726
		internal RecordActivatingEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x00081535 File Offset: 0x0007F735
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EC1 RID: 3777
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
