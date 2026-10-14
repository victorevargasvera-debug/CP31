using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200008C RID: 140
	internal class GridCellRangeValueProvider : global::Infragistics.Windows.DataPresenter.CellRangeValueProvider
	{
		// Token: 0x060006C7 RID: 1735 RVA: 0x0001B2C7 File Offset: 0x000194C7
		internal GridCellRangeValueProvider(global::Infragistics.Windows.DataPresenter.Cell[] cells, global::Infragistics.Windows.DataPresenter.Field[] fields) : this(cells, new global::Infragistics.Windows.DataPresenter.GridCellRange(cells, fields))
		{
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0001B2D7 File Offset: 0x000194D7
		internal GridCellRangeValueProvider(global::Infragistics.Windows.DataPresenter.Cell[] cells, int fieldCount) : this(cells, new global::Infragistics.Windows.DataPresenter.GridCellRange(cells, fieldCount))
		{
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0001B2E8 File Offset: 0x000194E8
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

		// Token: 0x060006CA RID: 1738 RVA: 0x0001B348 File Offset: 0x00019548
		public override global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(int recordIndex, int fieldIndex)
		{
			global::Infragistics.Windows.DataPresenter.Cell cell = base.GetCell(recordIndex, fieldIndex);
			if (cell == null)
			{
				return null;
			}
			return this.GetValue(cell);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0001B36A File Offset: 0x0001956A
		public override global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.CellKey cellKey)
		{
			return this.GetValue(cellKey.Cell);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0001B37C File Offset: 0x0001957C
		public override global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			int index;
			if (!this._valueIndexes.TryGetValue(cell, out index))
			{
				throw new global::System.ArgumentException();
			}
			return this._values[index];
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0001B3AB File Offset: 0x000195AB
		public override void CopyTo(global::System.Array array, int arrayIndex)
		{
			((global::System.Collections.ICollection)this._values).CopyTo(array, arrayIndex);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0001B3BA File Offset: 0x000195BA
		public override global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.CellValueHolder> GetValueEnumerator()
		{
			return this._values.GetEnumerator();
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x0001B3CC File Offset: 0x000195CC
		public override int ValueCount
		{
			get
			{
				return this._values.Count;
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0001B3F4 File Offset: 0x000195F4
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

		// Token: 0x060006D1 RID: 1745 RVA: 0x0001B4AC File Offset: 0x000196AC
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

		// Token: 0x060006D2 RID: 1746 RVA: 0x0001B518 File Offset: 0x00019718
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

		// Token: 0x040001F9 RID: 505
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Cell, int> _valueIndexes;

		// Token: 0x040001FA RID: 506
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellValueHolder> _values;
	}
}
