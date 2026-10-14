using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000092 RID: 146
	internal class GridCellRangeValueProvider : global::Infragistics.Windows.DataPresenter.CellRangeValueProvider
	{
		// Token: 0x0600074E RID: 1870 RVA: 0x0001DFA2 File Offset: 0x0001C1A2
		internal GridCellRangeValueProvider(global::Infragistics.Windows.DataPresenter.Cell[] cells, global::Infragistics.Windows.DataPresenter.Field[] fields) : this(cells, new global::Infragistics.Windows.DataPresenter.GridCellRange(cells, fields))
		{
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0001DFB4 File Offset: 0x0001C1B4
		private GridCellRangeValueProvider(global::Infragistics.Windows.DataPresenter.Cell[] cells, global::Infragistics.Windows.DataPresenter.GridCellRange range) : base(range)
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Cell, int> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Cell, int>();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellValueHolder> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellValueHolder>();
			foreach (global::Infragistics.Windows.DataPresenter.Cell cell in cells)
			{
				if (cell != null)
				{
					dictionary[cell] = list.Count;
					list.Add(new global::Infragistics.Windows.DataPresenter.CellValueHolder(null, false));
				}
			}
			this._values = list;
			this._valueIndexes = dictionary;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0001E014 File Offset: 0x0001C214
		public override global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(int recordIndex, int fieldIndex)
		{
			global::Infragistics.Windows.DataPresenter.Cell cell = base.GetCell(recordIndex, fieldIndex);
			if (cell == null)
			{
				return null;
			}
			return this.GetValue(cell);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0001E036 File Offset: 0x0001C236
		public override global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.CellKey cellKey)
		{
			return this.GetValue(cellKey.Cell);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0001E048 File Offset: 0x0001C248
		public override global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			int index;
			if (!this._valueIndexes.TryGetValue(cell, out index))
			{
				throw new global::System.ArgumentException();
			}
			return this._values[index];
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0001E077 File Offset: 0x0001C277
		public override void CopyTo(global::System.Array array, int arrayIndex)
		{
			((global::System.Collections.ICollection)this._values).CopyTo(array, arrayIndex);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0001E086 File Offset: 0x0001C286
		public override global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.CellValueHolder> GetValueEnumerator()
		{
			return this._values.GetEnumerator();
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x0001E098 File Offset: 0x0001C298
		public override int ValueCount
		{
			get
			{
				return this._values.Count;
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0001E0C0 File Offset: 0x0001C2C0
		public override global::Infragistics.Windows.DataPresenter.ICellValueProvider GetCurrentCellValues(bool useConvertedValues)
		{
			global::Infragistics.Windows.DataPresenter.GridCellRange gridCellRange = (global::Infragistics.Windows.DataPresenter.GridCellRange)base.Range;
			global::Infragistics.Windows.DataPresenter.Cell[] array = gridCellRange.Cells;
			global::System.Predicate<global::Infragistics.Windows.DataPresenter.Cell> match = (global::Infragistics.Windows.DataPresenter.Cell cell) => cell != null && cell.Record != null && cell.Record.IsAddRecordTemplate;
			int num = global::System.Array.FindIndex<global::Infragistics.Windows.DataPresenter.Cell>(array, match);
			if (num >= 0)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Cell> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Cell>(array);
				list.RemoveAll(match);
				array = list.ToArray();
			}
			global::Infragistics.Windows.DataPresenter.GridCellRangeValueProvider gridCellRangeValueProvider = new global::Infragistics.Windows.DataPresenter.GridCellRangeValueProvider(array, gridCellRange.GetFields());
			foreach (global::Infragistics.Windows.DataPresenter.Cell cell2 in array)
			{
				if (cell2 != null)
				{
					object value = useConvertedValues ? cell2.ConvertedValue : cell2.Value;
					gridCellRangeValueProvider.GetValue(cell2).Initialize(value, false);
				}
			}
			return gridCellRangeValueProvider;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0001E178 File Offset: 0x0001C378
		protected override void OnRecordChanged(global::Infragistics.Windows.DataPresenter.DataRecord oldRecord, global::Infragistics.Windows.DataPresenter.DataRecord newRecord)
		{
			int i = 0;
			int fieldCount = base.FieldCount;
			while (i < fieldCount)
			{
				global::Infragistics.Windows.DataPresenter.Field field = base.GetField(i);
				global::Infragistics.Windows.DataPresenter.Cell cellIfAllocated = oldRecord.GetCellIfAllocated(field);
				int value;
				if (cellIfAllocated != null && this._valueIndexes.TryGetValue(cellIfAllocated, out value))
				{
					this._valueIndexes.Remove(cellIfAllocated);
					this._valueIndexes[newRecord.Cells[field]] = value;
				}
				i++;
			}
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0001E1E4 File Offset: 0x0001C3E4
		public override void SetValue(int recordIndex, int fieldIndex, global::Infragistics.Windows.DataPresenter.CellValueHolder newValue)
		{
			global::Infragistics.Windows.DataPresenter.Cell cell = base.GetCell(recordIndex, fieldIndex);
			if (cell == null)
			{
				return;
			}
			int index;
			if (this._valueIndexes.TryGetValue(cell, out index))
			{
				this._values[index] = newValue;
			}
		}

		// Token: 0x0400023D RID: 573
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Cell, int> _valueIndexes;

		// Token: 0x0400023E RID: 574
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellValueHolder> _values;
	}
}
