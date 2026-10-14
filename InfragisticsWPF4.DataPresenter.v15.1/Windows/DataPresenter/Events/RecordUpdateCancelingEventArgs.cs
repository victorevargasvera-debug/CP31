using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002E5 RID: 741
	public class RecordUpdateCancelingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x060022C6 RID: 8902 RVA: 0x00097FFF File Offset: 0x000961FF
		internal RecordUpdateCancelingEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x0009800E File Offset: 0x0009620E
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04001153 RID: 4435
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;
	}
}
