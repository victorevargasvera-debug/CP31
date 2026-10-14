using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001BC RID: 444
	public class ClipboardCopyingEventArgs : global::Infragistics.CancellableEventArgs
	{
		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0002A6E7 File Offset: 0x000288E7
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x0002A6EF File Offset: 0x000288EF
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.CellBase> SelectedItems { get; protected internal set; }

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x0002A6F8 File Offset: 0x000288F8
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x0002A700 File Offset: 0x00028900
		public string ClipboardValue { get; set; }

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0002A709 File Offset: 0x00028909
		internal ClipboardCopyingEventArgs(global::Infragistics.Controls.Grids.XamGrid grid)
		{
			this._grid = grid;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0002A788 File Offset: 0x00028988
		public bool ValidateSelectedRectangle()
		{
			if (this._grid == null)
			{
				return false;
			}
			if (this.GetCopyTypeResolved() == global::Infragistics.Controls.Grids.GridClipboardCopyType.SelectedRows)
			{
				global::Infragistics.Controls.Grids.SelectedRowsCollection selectedRows = this._grid.SelectionSettings.SelectedRows;
				if (!selectedRows.Any<global::Infragistics.Controls.Grids.Row>() || this.IsSelectionCrossBand())
				{
					return false;
				}
				int num = selectedRows.Min((global::Infragistics.Controls.Grids.Row r) => r.Index);
				int num2 = selectedRows.Max((global::Infragistics.Controls.Grids.Row r) => r.Index);
				if (num2 - num + 1 == selectedRows.Count)
				{
					return true;
				}
			}
			else
			{
				global::Infragistics.Controls.Grids.SelectedCellsCollection selectedCells = this._grid.SelectionSettings.SelectedCells;
				if (!selectedCells.Any<global::Infragistics.Controls.Grids.Cell>() || this.IsSelectionCrossBand())
				{
					return false;
				}
				global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.ColumnBase> allColumns = (from i in selectedCells[0].Column.ColumnLayout.Columns.AllColumns
				where i is global::Infragistics.Controls.Grids.Column && !(i is global::Infragistics.Controls.Grids.GroupColumn)
				select i).ToList<global::Infragistics.Controls.Grids.ColumnBase>();
				int num3 = selectedCells.Min((global::Infragistics.Controls.Grids.Cell c) => c.Row.Index);
				int num4 = selectedCells.Max((global::Infragistics.Controls.Grids.Cell c) => c.Row.Index);
				int num5 = selectedCells.Min((global::Infragistics.Controls.Grids.Cell c) => allColumns.IndexOf(c.Column));
				int num6 = selectedCells.Max((global::Infragistics.Controls.Grids.Cell c) => allColumns.IndexOf(c.Column));
				int num7 = (num6 - num5 + 1) * (num4 - num3 + 1);
				if (num7 == selectedCells.Count)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0002A92A File Offset: 0x00028B2A
		private global::Infragistics.Controls.Grids.GridClipboardCopyType GetCopyTypeResolved()
		{
			if (this._grid.ClipboardSettings.CopyType != global::Infragistics.Controls.Grids.GridClipboardCopyType.Default)
			{
				return this._grid.ClipboardSettings.CopyType;
			}
			if (this._grid.SelectionSettings.CellClickAction == global::Infragistics.Controls.Grids.CellSelectionAction.SelectCell)
			{
				return global::Infragistics.Controls.Grids.GridClipboardCopyType.SelectedCells;
			}
			return global::Infragistics.Controls.Grids.GridClipboardCopyType.SelectedRows;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0002A9A4 File Offset: 0x00028BA4
		private bool IsSelectionCrossBand()
		{
			if (this.GetCopyTypeResolved() == global::Infragistics.Controls.Grids.GridClipboardCopyType.SelectedCells)
			{
				global::Infragistics.Controls.Grids.SelectedCellsCollection selectedCells = this._grid.SelectionSettings.SelectedCells;
				if (!selectedCells.Any<global::Infragistics.Controls.Grids.Cell>())
				{
					return false;
				}
				int level = selectedCells[0].Row.Level;
				return selectedCells.Any((global::Infragistics.Controls.Grids.Cell cell) => cell.Row.Level != level);
			}
			else
			{
				global::Infragistics.Controls.Grids.SelectedRowsCollection selectedRows = this._grid.SelectionSettings.SelectedRows;
				if (!selectedRows.Any<global::Infragistics.Controls.Grids.Row>())
				{
					return false;
				}
				int level = selectedRows[0].Level;
				return selectedRows.Any((global::Infragistics.Controls.Grids.Row row) => row.Level != level);
			}
		}

		// Token: 0x040003EA RID: 1002
		private global::Infragistics.Controls.Grids.XamGrid _grid;
	}
}
