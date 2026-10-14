using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000129 RID: 297
	public class SelectedCellsCollection : global::Infragistics.Controls.Grids.SelectedCollectionBase<global::Infragistics.Controls.Grids.Cell>
	{
		// Token: 0x060009D2 RID: 2514 RVA: 0x00026384 File Offset: 0x00024584
		protected override void OnSelectionChanged(global::Infragistics.Controls.Grids.SelectedCollectionBase<global::Infragistics.Controls.Grids.Cell> oldCollection, global::Infragistics.Controls.Grids.SelectedCollectionBase<global::Infragistics.Controls.Grids.Cell> newCollection)
		{
			if (base.Grid != null)
			{
				base.Grid.OnSelectedCellsCollectionChanged((global::Infragistics.Controls.Grids.SelectedCellsCollection)oldCollection, (global::Infragistics.Controls.Grids.SelectedCellsCollection)newCollection);
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000263A5 File Offset: 0x000245A5
		protected override global::Infragistics.Controls.Grids.SelectedCollectionBase<global::Infragistics.Controls.Grids.Cell> CreateNewInstance()
		{
			return new global::Infragistics.Controls.Grids.SelectedCellsCollection();
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000263AC File Offset: 0x000245AC
		protected override void AddItem(int index, global::Infragistics.Controls.Grids.Cell item)
		{
			if (item.Column.SupportsActivationAndSelection)
			{
				base.AddItem(index, item);
			}
		}
	}
}
