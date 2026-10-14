using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002A2 RID: 674
	public class RecordUpdateCancelingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001E3E RID: 7742 RVA: 0x0008186B File Offset: 0x0007FA6B
		internal RecordUpdateCancelingEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06001E3F RID: 7743 RVA: 0x0008187A File Offset: 0x0007FA7A
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EE9 RID: 3817
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;
	}
}
