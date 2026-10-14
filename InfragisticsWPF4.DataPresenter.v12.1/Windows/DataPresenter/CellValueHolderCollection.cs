using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200007F RID: 127
	public class CellValueHolderCollection : global::System.Collections.ICollection, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.CellValueHolder>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000629 RID: 1577 RVA: 0x000181C5 File Offset: 0x000163C5
		internal CellValueHolderCollection(global::Infragistics.Windows.DataPresenter.ICellValueProvider valueProvider)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(valueProvider, "valueProvider");
			this._valueProvider = valueProvider;
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x000181DF File Offset: 0x000163DF
		internal global::Infragistics.Windows.DataPresenter.ICellValueProvider ValueProvider
		{
			get
			{
				return this._valueProvider;
			}
		}

		// Token: 0x170001B3 RID: 435
		public global::Infragistics.Windows.DataPresenter.CellValueHolder this[int recordIndex, int fieldIndex]
		{
			get
			{
				return this._valueProvider.GetValue(recordIndex, fieldIndex);
			}
		}

		// Token: 0x170001B4 RID: 436
		public global::Infragistics.Windows.DataPresenter.CellValueHolder this[global::Infragistics.Windows.DataPresenter.Cell cell]
		{
			get
			{
				return this._valueProvider.GetValue(cell);
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00018204 File Offset: 0x00016404
		public int FieldCount
		{
			get
			{
				return this._valueProvider.FieldCount;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00018211 File Offset: 0x00016411
		public int RecordCount
		{
			get
			{
				return this._valueProvider.RecordCount;
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0001821E File Offset: 0x0001641E
		internal void ConvertToDisplayText()
		{
			global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.ConvertToDisplayText(this._valueProvider);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0001822B File Offset: 0x0001642B
		internal global::Infragistics.Windows.DataPresenter.Cell GetCell(int row, int column)
		{
			return this._valueProvider.GetCell(row, column);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0001823A File Offset: 0x0001643A
		internal global::Infragistics.Windows.DataPresenter.Field GetField(int fieldIndex)
		{
			return this._valueProvider.GetField(fieldIndex);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00018248 File Offset: 0x00016448
		internal global::Infragistics.Windows.DataPresenter.DataRecord GetRecord(int row)
		{
			return this._valueProvider.GetRecord(row);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00018258 File Offset: 0x00016458
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

		// Token: 0x06000634 RID: 1588 RVA: 0x00018288 File Offset: 0x00016488
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

		// Token: 0x06000635 RID: 1589 RVA: 0x000182B5 File Offset: 0x000164B5
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			this._valueProvider.CopyTo(array, index);
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x000182C4 File Offset: 0x000164C4
		int global::System.Collections.ICollection.Count
		{
			get
			{
				return this._valueProvider.ValueCount;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x000182D1 File Offset: 0x000164D1
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x000182D4 File Offset: 0x000164D4
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this._valueProvider;
			}
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x000182DC File Offset: 0x000164DC
		global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.CellValueHolder> global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.CellValueHolder>.GetEnumerator()
		{
			return this._valueProvider.GetValueEnumerator();
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000182E9 File Offset: 0x000164E9
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._valueProvider.GetValueEnumerator();
		}

		// Token: 0x040001DC RID: 476
		private global::Infragistics.Windows.DataPresenter.ICellValueProvider _valueProvider;
	}
}
