using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002B6 RID: 694
	public class CellUpdatedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x0600220A RID: 8714 RVA: 0x000975EE File Offset: 0x000957EE
		internal CellUpdatedEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._record = record;
			this._field = field;
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x00097604 File Offset: 0x00095804
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._record.Cells[this._field];
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x0600220C RID: 8716 RVA: 0x0009761C File Offset: 0x0009581C
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x00097624 File Offset: 0x00095824
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x040010F1 RID: 4337
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x040010F2 RID: 4338
		private global::Infragistics.Windows.DataPresenter.Field _field;
	}
}
