using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000274 RID: 628
	public class CellUpdatingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001D8A RID: 7562 RVA: 0x00080ECC File Offset: 0x0007F0CC
		internal CellUpdatingEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._record = record;
			this._field = field;
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x00080EE2 File Offset: 0x0007F0E2
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._record.Cells[this._field];
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x00080EFA File Offset: 0x0007F0FA
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x00080F02 File Offset: 0x0007F102
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000E8C RID: 3724
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x04000E8D RID: 3725
		private global::Infragistics.Windows.DataPresenter.Field _field;
	}
}
