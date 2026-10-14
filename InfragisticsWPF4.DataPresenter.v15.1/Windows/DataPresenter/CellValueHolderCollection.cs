using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000084 RID: 132
	public class CellValueHolderCollection : global::System.Collections.ICollection, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.CellValueHolder>, global::System.Collections.IEnumerable
	{
		// Token: 0x060006A4 RID: 1700 RVA: 0x0001A745 File Offset: 0x00018945
		internal CellValueHolderCollection(global::Infragistics.Windows.DataPresenter.ICellValueProvider valueProvider)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(valueProvider, "valueProvider");
			this._valueProvider = valueProvider;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x0001A75F File Offset: 0x0001895F
		internal global::Infragistics.Windows.DataPresenter.ICellValueProvider ValueProvider
		{
			get
			{
				return this._valueProvider;
			}
		}

		// Token: 0x170001D7 RID: 471
		public global::Infragistics.Windows.DataPresenter.CellValueHolder this[int recordIndex, int fieldIndex]
		{
			get
			{
				return this._valueProvider.GetValue(recordIndex, fieldIndex);
			}
		}

		// Token: 0x170001D8 RID: 472
		public global::Infragistics.Windows.DataPresenter.CellValueHolder this[global::Infragistics.Windows.DataPresenter.Cell cell]
		{
			get
			{
				return this._valueProvider.GetValue(cell);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x0001A784 File Offset: 0x00018984
		public int FieldCount
		{
			get
			{
				return this._valueProvider.FieldCount;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0001A791 File Offset: 0x00018991
		public int RecordCount
		{
			get
			{
				return this._valueProvider.RecordCount;
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0001A79E File Offset: 0x0001899E
		internal void ConvertToDisplayText()
		{
			global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.ConvertToDisplayText(this._valueProvider);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0001A7AB File Offset: 0x000189AB
		internal global::Infragistics.Windows.DataPresenter.Cell GetCell(int row, int column)
		{
			return this._valueProvider.GetCell(row, column);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0001A7BA File Offset: 0x000189BA
		internal global::Infragistics.Windows.DataPresenter.Field GetField(int fieldIndex)
		{
			return this._valueProvider.GetField(fieldIndex);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0001A7C8 File Offset: 0x000189C8
		internal global::Infragistics.Windows.DataPresenter.Field GetFieldForRecord(int fieldIndex, int recordIndex)
		{
			return this._valueProvider.GetFieldForRecord(fieldIndex, recordIndex);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0001A7D7 File Offset: 0x000189D7
		internal global::Infragistics.Windows.DataPresenter.DataRecord GetRecord(int row)
		{
			return this._valueProvider.GetRecord(row);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0001A7E8 File Offset: 0x000189E8
		internal int IndexOf(global::Infragistics.Windows.DataPresenter.Field field)
		{
			int i = 0;
			int fieldCount = this.FieldCount;
			while (i < fieldCount)
			{
				if (this.GetField(i) == field)
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0001A818 File Offset: 0x00018A18
		internal int IndexOf(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			int i = 0;
			int recordCount = this.RecordCount;
			while (i < recordCount)
			{
				if (this.GetRecord(i) == record)
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0001A845 File Offset: 0x00018A45
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			this._valueProvider.CopyTo(array, index);
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x0001A854 File Offset: 0x00018A54
		int global::System.Collections.ICollection.Count
		{
			get
			{
				return this._valueProvider.ValueCount;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0001A861 File Offset: 0x00018A61
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x0001A864 File Offset: 0x00018A64
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this._valueProvider;
			}
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0001A86C File Offset: 0x00018A6C
		global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.CellValueHolder> global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.CellValueHolder>.GetEnumerator()
		{
			return this._valueProvider.GetValueEnumerator();
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0001A879 File Offset: 0x00018A79
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._valueProvider.GetValueEnumerator();
		}

		// Token: 0x04000218 RID: 536
		private global::Infragistics.Windows.DataPresenter.ICellValueProvider _valueProvider;
	}
}
