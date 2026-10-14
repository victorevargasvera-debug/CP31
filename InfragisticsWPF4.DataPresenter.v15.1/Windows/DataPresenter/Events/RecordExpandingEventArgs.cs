using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002D9 RID: 729
	public class RecordExpandingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06002293 RID: 8851 RVA: 0x00097D5B File Offset: 0x00095F5B
		internal RecordExpandingEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x00097D6A File Offset: 0x00095F6A
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04001132 RID: 4402
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
