using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000093 RID: 147
	internal class RecordCellRangeValueProvider : global::Infragistics.Windows.DataPresenter.CellRangeValueProvider
	{
		// Token: 0x0600075A RID: 1882 RVA: 0x0001E21B File Offset: 0x0001C41B
		internal RecordCellRangeValueProvider(global::Infragistics.Windows.DataPresenter.DataRecord[] records, global::Infragistics.Windows.DataPresenter.Field[] fields) : this(records, fields, null, false)
		{
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0001E228 File Offset: 0x0001C428
		internal RecordCellRangeValueProvider(global::Infragistics.Windows.DataPresenter.DataRecord[] records, global::Infragistics.Windows.DataPresenter.Field[] fields, global::Infragistics.Windows.DataPresenter.CellValueHolder[,] values, bool keepExtraRowData) : base(new global::Infragistics.Windows.DataPresenter.RecordCellRange(records, fields))
		{
			this._range = (global::Infragistics.Windows.DataPresenter.RecordCellRange)base.Range;
			int num = this._range.FieldCount * this._range.RecordCount;
			global::Infragistics.Windows.DataPresenter.CellValueHolder[] array;
			if (values == null)
			{
				array = new global::Infragistics.Windows.DataPresenter.CellValueHolder[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = new global::Infragistics.Windows.DataPresenter.CellValueHolder(null, false);
				}
				this._rowCount = this._range.RecordCount;
			}
			else
			{
				int num2;
				int num3;
				global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetRowColumnCount(values, out num2, out num3);
				int num4 = keepExtraRowData ? num2 : this._range.RecordCount;
				int fieldCount = this._range.FieldCount;
				int num5 = fieldCount * num4;
				array = new global::Infragistics.Windows.DataPresenter.CellValueHolder[num5];
				int num6 = 0;
				for (int j = 0; j < num4; j++)
				{
					for (int k = 0; k < fieldCount; k++)
					{
						array[num6++] = values[j, k];
					}
				}
				this._rowCount = num4;
			}
			this._values = array;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0001E320 File Offset: 0x0001C520
		private void CreateValueIndexes()
		{
			this._valueIndexes = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.CellKey, int>();
			int fieldCount = this._range.FieldCount;
			int num = 0;
			int i = 0;
			int recordCount = this._range.RecordCount;
			while (i < recordCount)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = this._range.GetRecord(i);
				for (int j = 0; j < base.FieldCount; j++)
				{
					this._valueIndexes[new global::Infragistics.Windows.DataPresenter.CellKey(record, base.GetFieldForRecord(j, i))] = num++;
				}
				i++;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x0001E39F File Offset: 0x0001C59F
		public override int RecordCount
		{
			get
			{
				return this._rowCount;
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0001E3A7 File Offset: 0x0001C5A7
		public override global::Infragistics.Windows.DataPresenter.DataRecord GetRecord(int recordIndex)
		{
			if (recordIndex < this._range.RecordCount)
			{
				return base.GetRecord(recordIndex);
			}
			return null;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0001E3C0 File Offset: 0x0001C5C0
		public override global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(int recordIndex, int fieldIndex)
		{
			return this._values[recordIndex * this._range.FieldCount + fieldIndex];
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0001E3D8 File Offset: 0x0001C5D8
		public override global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			global::Infragistics.Windows.DataPresenter.CellKey cellKey = new global::Infragistics.Windows.DataPresenter.CellKey(cell);
			return this.GetValue(cellKey);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0001E3F4 File Offset: 0x0001C5F4
		public override global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.CellKey cellKey)
		{
			if (this._valueIndexes == null)
			{
				this.CreateValueIndexes();
			}
			int num = this._valueIndexes[cellKey];
			return this._values[num];
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0001E424 File Offset: 0x0001C624
		public override void CopyTo(global::System.Array array, int arrayIndex)
		{
			this._values.CopyTo(array, arrayIndex);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0001E433 File Offset: 0x0001C633
		public override global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.CellValueHolder> GetValueEnumerator()
		{
			return ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.CellValueHolder>)this._values).GetEnumerator();
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x0001E445 File Offset: 0x0001C645
		public override int ValueCount
		{
			get
			{
				return this._values.Length;
			}
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0001E458 File Offset: 0x0001C658
		public override global::Infragistics.Windows.DataPresenter.ICellValueProvider GetCurrentCellValues(bool useConvertedValues)
		{
			global::Infragistics.Windows.DataPresenter.RecordCellRange recordCellRange = (global::Infragistics.Windows.DataPresenter.RecordCellRange)base.Range;
			global::Infragistics.Windows.DataPresenter.DataRecord[] array = recordCellRange.Records;
			global::Infragistics.Windows.DataPresenter.Field[] fields = recordCellRange.Fields;
			global::System.Predicate<global::Infragistics.Windows.DataPresenter.DataRecord> match = (global::Infragistics.Windows.DataPresenter.DataRecord record) => record.IsAddRecordTemplate;
			int num = global::System.Array.FindIndex<global::Infragistics.Windows.DataPresenter.DataRecord>(array, match);
			if (num >= 0)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>(array);
				list.RemoveAll(match);
				array = list.ToArray();
			}
			global::Infragistics.Windows.DataPresenter.RecordCellRangeValueProvider recordCellRangeValueProvider = new global::Infragistics.Windows.DataPresenter.RecordCellRangeValueProvider(array, fields);
			global::Infragistics.Windows.DataPresenter.ClipboardFieldArrayProvider clipboardFieldArrayProvider = new global::Infragistics.Windows.DataPresenter.ClipboardFieldArrayProvider(fields);
			for (int i = 0; i < array.Length; i++)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = array[i];
				global::Infragistics.Windows.DataPresenter.Field[] fields2 = clipboardFieldArrayProvider.GetFields(dataRecord.FieldLayout);
				for (int j = 0; j < fields2.Length; j++)
				{
					global::Infragistics.Windows.DataPresenter.CellValueHolder value = recordCellRangeValueProvider.GetValue(i, j);
					if (value != null)
					{
						object cellValue = dataRecord.GetCellValue(fields2[j], useConvertedValues);
						value.Initialize(cellValue, false);
					}
				}
			}
			return recordCellRangeValueProvider;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0001E53C File Offset: 0x0001C73C
		protected override void OnRecordChanged(global::Infragistics.Windows.DataPresenter.DataRecord oldRecord, global::Infragistics.Windows.DataPresenter.DataRecord newRecord)
		{
			int i = 0;
			int fieldCount = base.FieldCount;
			while (i < fieldCount)
			{
				global::Infragistics.Windows.DataPresenter.Field field = base.GetField(i);
				global::Infragistics.Windows.DataPresenter.CellKey key = new global::Infragistics.Windows.DataPresenter.CellKey(oldRecord, field);
				int value;
				if (this._valueIndexes.TryGetValue(key, out value))
				{
					this._valueIndexes.Remove(key);
					this._valueIndexes[new global::Infragistics.Windows.DataPresenter.CellKey(newRecord, field)] = value;
				}
				i++;
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0001E59F File Offset: 0x0001C79F
		public override void SetValue(int recordIndex, int fieldIndex, global::Infragistics.Windows.DataPresenter.CellValueHolder newValue)
		{
			this._values[recordIndex * this._range.FieldCount + fieldIndex] = newValue;
		}

		// Token: 0x04000240 RID: 576
		private global::Infragistics.Windows.DataPresenter.RecordCellRange _range;

		// Token: 0x04000241 RID: 577
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.CellKey, int> _valueIndexes;

		// Token: 0x04000242 RID: 578
		private global::Infragistics.Windows.DataPresenter.CellValueHolder[] _values;

		// Token: 0x04000243 RID: 579
		private int _rowCount;
	}
}
