using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000278 RID: 632
	public class ClipboardPastingEventArgs : global::Infragistics.Windows.DataPresenter.Events.ClipboardOperationEventArgs
	{
		// Token: 0x06001DA8 RID: 7592 RVA: 0x000810A2 File Offset: 0x0007F2A2
		internal ClipboardPastingEventArgs(global::Infragistics.Windows.DataPresenter.CellValueHolderCollection values, global::System.Windows.IDataObject dataObject) : base(values)
		{
			this._dataObject = dataObject;
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x000810B2 File Offset: 0x0007F2B2
		public global::System.Windows.IDataObject DataObject
		{
			get
			{
				return this._dataObject;
			}
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x000810BA File Offset: 0x0007F2BA
		public global::Infragistics.Windows.DataPresenter.Cell GetTargetCell(int row, int column)
		{
			return base.Values.GetCell(row, column);
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x000810C9 File Offset: 0x0007F2C9
		public global::Infragistics.Windows.DataPresenter.Field GetTargetField(int column)
		{
			return base.Values.GetField(column);
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x000810D7 File Offset: 0x0007F2D7
		public int GetTargetFieldIndex(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return base.Values.IndexOf(field);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x000810E5 File Offset: 0x0007F2E5
		public global::Infragistics.Windows.DataPresenter.DataRecord GetTargetRecord(int row)
		{
			return base.Values.GetRecord(row);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x000810F3 File Offset: 0x0007F2F3
		public int GetTargetRecordIndex(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			return base.Values.IndexOf(record);
		}

		// Token: 0x04000E98 RID: 3736
		private global::System.Windows.IDataObject _dataObject;
	}
}
