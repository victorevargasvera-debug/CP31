using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002B7 RID: 695
	public class CellUpdatingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x0600220E RID: 8718 RVA: 0x0009762C File Offset: 0x0009582C
		internal CellUpdatingEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._record = record;
			this._field = field;
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x00097642 File Offset: 0x00095842
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._record.Cells[this._field];
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x0009765A File Offset: 0x0009585A
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06002211 RID: 8721 RVA: 0x00097662 File Offset: 0x00095862
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x040010F3 RID: 4339
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x040010F4 RID: 4340
		private global::Infragistics.Windows.DataPresenter.Field _field;
	}
}
