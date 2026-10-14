using System;
using System.ComponentModel;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000EA RID: 234
	public class RowFiltersCollection : global::Infragistics.RecordFilterCollection
	{
		// Token: 0x060007AC RID: 1964 RVA: 0x0001FBA8 File Offset: 0x0001DDA8
		public global::Infragistics.Controls.Grids.RowsFilter GetRowFilterByColumnKey(string columnKey)
		{
			foreach (global::Infragistics.IRecordFilter recordFilter in this.Items)
			{
				if (recordFilter.FieldName == columnKey)
				{
					return recordFilter as global::Infragistics.Controls.Grids.RowsFilter;
				}
			}
			return null;
		}

		// Token: 0x1700025E RID: 606
		public global::Infragistics.Controls.Grids.RowsFilter this[string key]
		{
			get
			{
				return this.GetRowFilterByColumnKey(key);
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0001FC11 File Offset: 0x0001DE11
		protected override void OnItemAdded(int index, global::Infragistics.IRecordFilter item)
		{
			base.OnItemAdded(index, item);
			item.PropertyChanged += this.Item_PropertyChanged;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0001FC30 File Offset: 0x0001DE30
		protected override void AddItem(int index, global::Infragistics.IRecordFilter item)
		{
			global::Infragistics.Controls.Grids.RowsFilter rowsFilter = item as global::Infragistics.Controls.Grids.RowsFilter;
			if (rowsFilter == null || rowsFilter.Column == null || rowsFilter.Column.CanBeFiltered)
			{
				base.AddItem(index, item);
			}
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0001FC64 File Offset: 0x0001DE64
		protected override void OnItemRemoved(int index, global::Infragistics.IRecordFilter item)
		{
			base.OnItemRemoved(index, item);
			item.PropertyChanged -= this.Item_PropertyChanged;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0001FC80 File Offset: 0x0001DE80
		protected override void ResetItems()
		{
			foreach (global::Infragistics.IRecordFilter recordFilter in this.Items)
			{
				recordFilter.PropertyChanged -= this.Item_PropertyChanged;
			}
			base.ResetItems();
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0001FCE0 File Offset: 0x0001DEE0
		private void Item_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnCollectionItemChanged();
		}
	}
}
