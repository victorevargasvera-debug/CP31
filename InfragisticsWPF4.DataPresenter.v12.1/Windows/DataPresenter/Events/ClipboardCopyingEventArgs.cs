using System;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000277 RID: 631
	public class ClipboardCopyingEventArgs : global::Infragistics.Windows.DataPresenter.Events.ClipboardOperationEventArgs
	{
		// Token: 0x06001DA0 RID: 7584 RVA: 0x00081020 File Offset: 0x0007F220
		internal ClipboardCopyingEventArgs(global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolderCollection values) : base(values)
		{
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x0008102C File Offset: 0x0007F22C
		public global::Infragistics.Windows.DataPresenter.CellValueHolder GetLabelValueHolder(int column)
		{
			global::Infragistics.Windows.DataPresenter.Field sourceField = this.GetSourceField(column);
			return this.GetLabelValueHolder(sourceField);
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00081048 File Offset: 0x0007F248
		public global::Infragistics.Windows.DataPresenter.CellValueHolder GetLabelValueHolder(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return ((global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolderCollection)base.Values).GetLabel(field);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x0008105B File Offset: 0x0007F25B
		public global::Infragistics.Windows.DataPresenter.Cell GetSourceCell(int row, int column)
		{
			return base.Values.GetCell(row, column);
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x0008106A File Offset: 0x0007F26A
		public global::Infragistics.Windows.DataPresenter.Field GetSourceField(int column)
		{
			return base.Values.GetField(column);
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00081078 File Offset: 0x0007F278
		public int GetSourceFieldIndex(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return base.Values.IndexOf(field);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00081086 File Offset: 0x0007F286
		public int GetSourceRecordIndex(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			return base.Values.IndexOf(record);
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00081094 File Offset: 0x0007F294
		public global::Infragistics.Windows.DataPresenter.DataRecord GetSourceRecord(int row)
		{
			return base.Values.GetRecord(row);
		}
	}
}
