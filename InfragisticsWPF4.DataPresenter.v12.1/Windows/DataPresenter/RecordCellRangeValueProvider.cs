using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200008D RID: 141
	internal class RecordCellRangeValueProvider : global::Infragistics.Windows.DataPresenter.CellRangeValueProvider
	{
		// Token: 0x060006D4 RID: 1748 RVA: 0x0001B54F File Offset: 0x0001974F
		internal RecordCellRangeValueProvider(global::Infragistics.Windows.DataPresenter.DataRecord[] records, global::Infragistics.Windows.DataPresenter.Field[] fields) : this(records, fields, null, false)
		{
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0001B55C File Offset: 0x0001975C
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

		// Token: 0x060006D6 RID: 1750 RVA: 0x0001B654 File Offset: 0x00019854
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
					this._valueIndexes[new global::Infragistics.Windows.DataPresenter.CellKey(record, this._range.GetField(j))] = num++;
				}
				i++;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0001B6D7 File Offset: 0x000198D7
		public override int RecordCount
		{
			get
			{
				return this._rowCount;
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0001B6DF File Offset: 0x000198DF
		public override global::Infragistics.Windows.DataPresenter.DataRecord GetRecord(int recordIndex)
		{
			if (recordIndex < this._range.RecordCount)
			{
				return base.GetRecord(recordIndex);
			}
			return null;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0001B6F8 File Offset: 0x000198F8
		public override global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(int recordIndex, int fieldIndex)
		{
			return this._values[recordIndex * this._range.FieldCount + fieldIndex];
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0001B710 File Offset: 0x00019910
		public override global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			global::Infragistics.Windows.DataPresenter.CellKey cellKey = new global::Infragistics.Windows.DataPresenter.CellKey(cell);
			return this.GetValue(cellKey);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0001B72C File Offset: 0x0001992C
		public override global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.CellKey cellKey)
		{
			if (this._valueIndexes == null)
			{
				this.CreateValueIndexes();
			}
			int num = this._valueIndexes[cellKey];
			return this._values[num];
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0001B75C File Offset: 0x0001995C
		public override void CopyTo(global::System.Array array, int arrayIndex)
		{
			this._values.CopyTo(array, arrayIndex);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0001B76B File Offset: 0x0001996B
		public override global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.CellValueHolder> GetValueEnumerator()
		{
			return ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.CellValueHolder>)this._values).GetEnumerator();
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0001B77D File Offset: 0x0001997D
		public override int ValueCount
		{
			get
			{
				return this._values.Length;
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0001B790 File Offset: 0x00019990
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
			for (int i = 0; i < array.Length; i++)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = array[i];
				for (int j = 0; j < fields.Length; j++)
				{
					global::Infragistics.Windows.DataPresenter.CellValueHolder value = recordCellRangeValueProvider.GetValue(i, j);
					if (value != null)
					{
						object cellValue = dataRecord.GetCellValue(fields[j], useConvertedValues);
						value.Initialize(cellValue, false);
					}
				}
			}
			return recordCellRangeValueProvider;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0001B85C File Offset: 0x00019A5C
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

		// Token: 0x060006E1 RID: 1761 RVA: 0x0001B8BF File Offset: 0x00019ABF
		public override void SetValue(int recordIndex, int fieldIndex, global::Infragistics.Windows.DataPresenter.CellValueHolder newValue)
		{
			this._values[recordIndex * this._range.FieldCount + fieldIndex] = newValue;
		}

		// Token: 0x040001FC RID: 508
		private global::Infragistics.Windows.DataPresenter.RecordCellRange _range;

		// Token: 0x040001FD RID: 509
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.CellKey, int> _valueIndexes;

		// Token: 0x040001FE RID: 510
		private global::Infragistics.Windows.DataPresenter.CellValueHolder[] _values;

		// Token: 0x040001FF RID: 511
		private int _rowCount;
	}
}
