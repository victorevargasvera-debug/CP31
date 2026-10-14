using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000091 RID: 145
	internal abstract class CellRangeValueProvider : global::Infragistics.Windows.DataPresenter.ICellValueProvider
	{
		// Token: 0x0600073A RID: 1850 RVA: 0x0001DE3C File Offset: 0x0001C03C
		protected CellRangeValueProvider(global::Infragistics.Windows.DataPresenter.CellRange range)
		{
			this._range = range;
			this._isTreeView = (range.FieldCount > 0 && range.GetField(0).Owner != null && range.GetField(0).Owner.DataPresenter.IsTreeView);
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x0001DE8C File Offset: 0x0001C08C
		protected global::Infragistics.Windows.DataPresenter.CellRange Range
		{
			get
			{
				return this._range;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x0001DE94 File Offset: 0x0001C094
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this.GetField(0).Owner;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x0001DEA2 File Offset: 0x0001C0A2
		public virtual int RecordCount
		{
			get
			{
				return this._range.RecordCount;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x0001DEAF File Offset: 0x0001C0AF
		public int FieldCount
		{
			get
			{
				return this._range.FieldCount;
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0001DEBC File Offset: 0x0001C0BC
		public global::Infragistics.Windows.DataPresenter.Cell GetCell(int recordIndex, int fieldIndex)
		{
			return this._range.GetCell(recordIndex, fieldIndex);
		}

		// Token: 0x06000740 RID: 1856
		public abstract global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(int recordIndex, int fieldIndex);

		// Token: 0x06000741 RID: 1857
		public abstract global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.Cell cell);

		// Token: 0x06000742 RID: 1858
		public abstract global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.CellKey cellKey);

		// Token: 0x06000743 RID: 1859 RVA: 0x0001DECB File Offset: 0x0001C0CB
		public global::Infragistics.Windows.DataPresenter.Field GetField(int fieldIndex)
		{
			return this._range.GetField(fieldIndex);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0001DEDC File Offset: 0x0001C0DC
		public global::Infragistics.Windows.DataPresenter.Field GetFieldForRecord(int fieldIndex, int recordIndex)
		{
			global::Infragistics.Windows.DataPresenter.Field field = this._range.GetField(fieldIndex);
			if (this._isTreeView)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = this.GetRecord(recordIndex);
				if (record != null && record.FieldLayout != field.Owner)
				{
					field = field.GetMappedFieldInTree(record.FieldLayout);
				}
			}
			return field;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0001DF25 File Offset: 0x0001C125
		public virtual global::Infragistics.Windows.DataPresenter.DataRecord GetRecord(int recordIndex)
		{
			return this._range.GetRecord(recordIndex);
		}

		// Token: 0x06000746 RID: 1862
		public abstract void CopyTo(global::System.Array array, int arrayIndex);

		// Token: 0x06000747 RID: 1863
		public abstract global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.CellValueHolder> GetValueEnumerator();

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000748 RID: 1864
		public abstract int ValueCount { get; }

		// Token: 0x06000749 RID: 1865
		public abstract global::Infragistics.Windows.DataPresenter.ICellValueProvider GetCurrentCellValues(bool useConvertedValues);

		// Token: 0x0600074A RID: 1866 RVA: 0x0001DF34 File Offset: 0x0001C134
		public void ReplaceRecord(int recordIndex, global::Infragistics.Windows.DataPresenter.DataRecord newRecord)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord record = this.GetRecord(recordIndex);
			if (record != null && record.FieldLayout == newRecord.FieldLayout)
			{
				this._range.SetRecord(recordIndex, newRecord);
				this.OnRecordChanged(record, newRecord);
			}
		}

		// Token: 0x0600074B RID: 1867
		protected abstract void OnRecordChanged(global::Infragistics.Windows.DataPresenter.DataRecord oldRecord, global::Infragistics.Windows.DataPresenter.DataRecord newRecord);

		// Token: 0x0600074C RID: 1868
		public abstract void SetValue(int recordIndex, int fieldIndex, global::Infragistics.Windows.DataPresenter.CellValueHolder newValue);

		// Token: 0x0600074D RID: 1869 RVA: 0x0001DF70 File Offset: 0x0001C170
		internal static global::Infragistics.Windows.DataPresenter.Field[] GetFields(global::Infragistics.Windows.DataPresenter.ICellValueProvider provider)
		{
			int fieldCount = provider.FieldCount;
			global::Infragistics.Windows.DataPresenter.Field[] array = new global::Infragistics.Windows.DataPresenter.Field[fieldCount];
			for (int i = 0; i < fieldCount; i++)
			{
				array[i] = provider.GetField(i);
			}
			return array;
		}

		// Token: 0x0400023B RID: 571
		private global::Infragistics.Windows.DataPresenter.CellRange _range;

		// Token: 0x0400023C RID: 572
		private bool _isTreeView;
	}
}
