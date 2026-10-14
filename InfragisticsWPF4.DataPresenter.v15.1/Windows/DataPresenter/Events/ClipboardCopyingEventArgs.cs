using System;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002BA RID: 698
	public class ClipboardCopyingEventArgs : global::Infragistics.Windows.DataPresenter.Events.ClipboardOperationEventArgs
	{
		// Token: 0x06002224 RID: 8740 RVA: 0x00097780 File Offset: 0x00095980
		internal ClipboardCopyingEventArgs(global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolderCollection values) : base(values)
		{
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x0009778C File Offset: 0x0009598C
		public global::Infragistics.Windows.DataPresenter.CellValueHolder GetLabelValueHolder(int column)
		{
			global::Infragistics.Windows.DataPresenter.Field sourceField = this.GetSourceField(column);
			return this.GetLabelValueHolder(sourceField);
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x000977A8 File Offset: 0x000959A8
		public global::Infragistics.Windows.DataPresenter.CellValueHolder GetLabelValueHolder(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return ((global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolderCollection)base.Values).GetLabel(field);
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x000977BB File Offset: 0x000959BB
		public global::Infragistics.Windows.DataPresenter.Cell GetSourceCell(int row, int column)
		{
			return base.Values.GetCell(row, column);
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x000977CA File Offset: 0x000959CA
		public global::Infragistics.Windows.DataPresenter.Field GetSourceField(int column)
		{
			return base.Values.GetField(column);
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x000977D8 File Offset: 0x000959D8
		public int GetSourceFieldIndex(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return base.Values.IndexOf(field);
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x000977E6 File Offset: 0x000959E6
		public int GetSourceRecordIndex(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			return base.Values.IndexOf(record);
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x000977F4 File Offset: 0x000959F4
		public global::Infragistics.Windows.DataPresenter.DataRecord GetSourceRecord(int row)
		{
			return base.Values.GetRecord(row);
		}
	}
}
