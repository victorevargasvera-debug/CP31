using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200012B RID: 299
	public class SelectedRowsCollection : global::Infragistics.Controls.Grids.SelectedCollectionBase<global::Infragistics.Controls.Grids.Row>
	{
		// Token: 0x060009DE RID: 2526 RVA: 0x00026571 File Offset: 0x00024771
		protected override void OnSelectionChanged(global::Infragistics.Controls.Grids.SelectedCollectionBase<global::Infragistics.Controls.Grids.Row> oldCollection, global::Infragistics.Controls.Grids.SelectedCollectionBase<global::Infragistics.Controls.Grids.Row> newCollection)
		{
			if (base.Grid != null)
			{
				base.Grid.OnSelectedRowsCollectionChanged((global::Infragistics.Controls.Grids.SelectedRowsCollection)oldCollection, (global::Infragistics.Controls.Grids.SelectedRowsCollection)newCollection);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00026592 File Offset: 0x00024792
		protected override global::Infragistics.Controls.Grids.SelectedCollectionBase<global::Infragistics.Controls.Grids.Row> CreateNewInstance()
		{
			return new global::Infragistics.Controls.Grids.SelectedRowsCollection();
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0002659C File Offset: 0x0002479C
		internal void SelectRange(global::Infragistics.Controls.Grids.RowCollection rows)
		{
			global::Infragistics.Controls.Grids.SelectedRowsCollection selectedRowsCollection = new global::Infragistics.Controls.Grids.SelectedRowsCollection();
			selectedRowsCollection.InternalAddRangeSilently(this);
			foreach (global::Infragistics.Controls.Grids.Row item in rows)
			{
				this.SelectItem(item, true);
			}
			this.OnSelectionChanged(selectedRowsCollection, this);
		}
	}
}
