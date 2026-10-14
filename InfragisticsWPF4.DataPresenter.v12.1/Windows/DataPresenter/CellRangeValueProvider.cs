using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200008B RID: 139
	internal abstract class CellRangeValueProvider : global::Infragistics.Windows.DataPresenter.ICellValueProvider
	{
		// Token: 0x060006B5 RID: 1717 RVA: 0x0001B222 File Offset: 0x00019422
		protected CellRangeValueProvider(global::Infragistics.Windows.DataPresenter.CellRange range)
		{
			this._range = range;
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0001B231 File Offset: 0x00019431
		protected global::Infragistics.Windows.DataPresenter.CellRange Range
		{
			get
			{
				return this._range;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x0001B239 File Offset: 0x00019439
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this.GetField(0).Owner;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0001B247 File Offset: 0x00019447
		public virtual int RecordCount
		{
			get
			{
				return this._range.RecordCount;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0001B254 File Offset: 0x00019454
		public int FieldCount
		{
			get
			{
				return this._range.FieldCount;
			}
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0001B261 File Offset: 0x00019461
		public global::Infragistics.Windows.DataPresenter.Cell GetCell(int recordIndex, int fieldIndex)
		{
			return this._range.GetCell(recordIndex, fieldIndex);
		}

		// Token: 0x060006BB RID: 1723
		public abstract global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(int recordIndex, int fieldIndex);

		// Token: 0x060006BC RID: 1724
		public abstract global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.Cell cell);

		// Token: 0x060006BD RID: 1725
		public abstract global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.CellKey cellKey);

		// Token: 0x060006BE RID: 1726 RVA: 0x0001B270 File Offset: 0x00019470
		public global::Infragistics.Windows.DataPresenter.Field GetField(int fieldIndex)
		{
			return this._range.GetField(fieldIndex);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0001B27E File Offset: 0x0001947E
		public virtual global::Infragistics.Windows.DataPresenter.DataRecord GetRecord(int recordIndex)
		{
			return this._range.GetRecord(recordIndex);
		}

		// Token: 0x060006C0 RID: 1728
		public abstract void CopyTo(global::System.Array array, int arrayIndex);

		// Token: 0x060006C1 RID: 1729
		public abstract global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.CellValueHolder> GetValueEnumerator();

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060006C2 RID: 1730
		public abstract int ValueCount { get; }

		// Token: 0x060006C3 RID: 1731
		public abstract global::Infragistics.Windows.DataPresenter.ICellValueProvider GetCurrentCellValues(bool useConvertedValues);

		// Token: 0x060006C4 RID: 1732 RVA: 0x0001B28C File Offset: 0x0001948C
		public void ReplaceRecord(int recordIndex, global::Infragistics.Windows.DataPresenter.DataRecord newRecord)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord record = this.GetRecord(recordIndex);
			if (record != null && record.FieldLayout == newRecord.FieldLayout)
			{
				this._range.SetRecord(recordIndex, newRecord);
				this.OnRecordChanged(record, newRecord);
			}
		}

		// Token: 0x060006C5 RID: 1733
		protected abstract void OnRecordChanged(global::Infragistics.Windows.DataPresenter.DataRecord oldRecord, global::Infragistics.Windows.DataPresenter.DataRecord newRecord);

		// Token: 0x060006C6 RID: 1734
		public abstract void SetValue(int recordIndex, int fieldIndex, global::Infragistics.Windows.DataPresenter.CellValueHolder newValue);

		// Token: 0x040001F8 RID: 504
		private global::Infragistics.Windows.DataPresenter.CellRange _range;
	}
}
