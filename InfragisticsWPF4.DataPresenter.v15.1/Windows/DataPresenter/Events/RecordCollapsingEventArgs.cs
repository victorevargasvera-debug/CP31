using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002D6 RID: 726
	public class RecordCollapsingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x0600228D RID: 8845 RVA: 0x00097D16 File Offset: 0x00095F16
		internal RecordCollapsingEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x00097D25 File Offset: 0x00095F25
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x0400112F RID: 4399
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
