using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002D7 RID: 727
	public class RecordDeactivatingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x0600228F RID: 8847 RVA: 0x00097D2D File Offset: 0x00095F2D
		internal RecordDeactivatingEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06002290 RID: 8848 RVA: 0x00097D3C File Offset: 0x00095F3C
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04001130 RID: 4400
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
