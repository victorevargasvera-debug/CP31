using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000273 RID: 627
	public class CellUpdatedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001D86 RID: 7558 RVA: 0x00080E8E File Offset: 0x0007F08E
		internal CellUpdatedEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._record = record;
			this._field = field;
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x00080EA4 File Offset: 0x0007F0A4
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._record.Cells[this._field];
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x00080EBC File Offset: 0x0007F0BC
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x00080EC4 File Offset: 0x0007F0C4
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000E8A RID: 3722
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x04000E8B RID: 3723
		private global::Infragistics.Windows.DataPresenter.Field _field;
	}
}
