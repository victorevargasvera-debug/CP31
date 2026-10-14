using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002BB RID: 699
	public class ClipboardPastingEventArgs : global::Infragistics.Windows.DataPresenter.Events.ClipboardOperationEventArgs
	{
		// Token: 0x0600222C RID: 8748 RVA: 0x00097802 File Offset: 0x00095A02
		internal ClipboardPastingEventArgs(global::Infragistics.Windows.DataPresenter.CellValueHolderCollection values, global::System.Windows.IDataObject dataObject) : base(values)
		{
			this._dataObject = dataObject;
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x00097812 File Offset: 0x00095A12
		public global::System.Windows.IDataObject DataObject
		{
			get
			{
				return this._dataObject;
			}
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x0009781A File Offset: 0x00095A1A
		public global::Infragistics.Windows.DataPresenter.Cell GetTargetCell(int row, int column)
		{
			return base.Values.GetCell(row, column);
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x00097829 File Offset: 0x00095A29
		public global::Infragistics.Windows.DataPresenter.Field GetTargetField(int column)
		{
			return base.Values.GetField(column);
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x00097837 File Offset: 0x00095A37
		public int GetTargetFieldIndex(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return base.Values.IndexOf(field);
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x00097845 File Offset: 0x00095A45
		public global::Infragistics.Windows.DataPresenter.DataRecord GetTargetRecord(int row)
		{
			return base.Values.GetRecord(row);
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x00097853 File Offset: 0x00095A53
		public int GetTargetRecordIndex(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			return base.Values.IndexOf(record);
		}

		// Token: 0x040010FF RID: 4351
		private global::System.Windows.IDataObject _dataObject;
	}
}
