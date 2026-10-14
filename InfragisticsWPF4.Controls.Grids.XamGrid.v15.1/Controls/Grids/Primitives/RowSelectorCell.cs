using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001ED RID: 493
	public class RowSelectorCell : global::Infragistics.Controls.Grids.CellBase
	{
		// Token: 0x06000DED RID: 3565 RVA: 0x00034306 File Offset: 0x00032506
		protected internal RowSelectorCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x00034310 File Offset: 0x00032510
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style == null)
				{
					return base.Row.ColumnLayout.RowSelectorSettings.StyleResolved;
				}
				return this.Style;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x00034336 File Offset: 0x00032536
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.Controls.Grids.Primitives.RowSelectorCell._recyclingElementType;
			}
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0003433D File Offset: 0x0003253D
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.RowSelectorCellControl();
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00034344 File Offset: 0x00032544
		protected internal override void EnsureCurrentState()
		{
			base.EnsureCurrentState();
			if (base.Control != null)
			{
				global::Infragistics.Controls.Grids.XamGrid grid = base.Row.ColumnLayout.Grid;
				if (grid.CurrentEditRow == base.Row || (grid.CurrentEditCell != null && grid.CurrentEditCell.Row == base.Row))
				{
					base.Control.GoToState("Editing", false);
				}
				else if (base.Row.ColumnLayout.Grid.ActiveCell != null && base.Row == base.Row.ColumnLayout.Grid.ActiveCell.Row)
				{
					base.Control.GoToState("Active", false);
				}
				else
				{
					base.Control.GoToState("InActive", false);
				}
				global::Infragistics.Controls.Grids.Row row = base.Row as global::Infragistics.Controls.Grids.Row;
				if (row != null)
				{
					if (row.IsSelected)
					{
						base.Control.GoToState("Selected", false);
						return;
					}
					base.Control.GoToState("NotSelected", false);
				}
			}
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0003444C File Offset: 0x0003264C
		protected internal override global::Infragistics.Controls.Grids.DragSelectType OnCellMouseDown(global::System.Windows.Input.MouseEventArgs e)
		{
			global::Infragistics.Controls.Grids.DragSelectType? dragSelectType = this.OnCellMouseDownImpl();
			if (dragSelectType != null)
			{
				return dragSelectType.Value;
			}
			return base.OnCellMouseDown(e);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00034478 File Offset: 0x00032678
		protected internal override void OnCellDragging(global::Infragistics.Controls.Grids.DragSelectType type)
		{
			base.OnCellDragging(type);
			global::Infragistics.Controls.Grids.XamGrid grid = base.Row.ColumnLayout.Grid;
			global::Infragistics.Controls.Grids.Row row = base.Row as global::Infragistics.Controls.Grids.Row;
			global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells = row.VisibleCells;
			if (row != null && visibleCells.Count > 0 && row.RowType != global::Infragistics.Controls.Grids.RowType.AddNewRow && row.RowType != global::Infragistics.Controls.Grids.RowType.FilterRow)
			{
				if (type == global::Infragistics.Controls.Grids.DragSelectType.Row)
				{
					grid.SelectRow(row, global::Infragistics.Controls.Grids.InvokeAction.MouseMove);
					return;
				}
				grid.SelectCell(visibleCells[0] as global::Infragistics.Controls.Grids.Cell, global::Infragistics.Controls.Grids.InvokeAction.MouseMove);
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x000344F0 File Offset: 0x000326F0
		protected internal override void OnCellClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.Row.ColumnLayout.Grid.OnRowSelectorClicked(base.Row);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00034510 File Offset: 0x00032710
		private global::Infragistics.Controls.Grids.DragSelectType? OnCellMouseDownImpl()
		{
			global::Infragistics.Controls.Grids.XamGrid grid = base.Row.ColumnLayout.Grid;
			global::Infragistics.Controls.Grids.Row row = base.Row as global::Infragistics.Controls.Grids.Row;
			if (row == null || row.Cells.Count <= 0)
			{
				return null;
			}
			if (!row.IsActive)
			{
				global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells = row.VisibleCells;
				if (visibleCells.Count > 0)
				{
					grid.SetActiveCell(visibleCells[0], global::Infragistics.Controls.Grids.CellAlignment.NotSet, global::Infragistics.Controls.Grids.InvokeAction.Click, false);
				}
			}
			if (grid.SelectRow(row, global::Infragistics.Controls.Grids.InvokeAction.Click))
			{
				return new global::Infragistics.Controls.Grids.DragSelectType?(global::Infragistics.Controls.Grids.DragSelectType.None);
			}
			return new global::Infragistics.Controls.Grids.DragSelectType?(global::Infragistics.Controls.Grids.DragSelectType.Row);
		}

		// Token: 0x0400048E RID: 1166
		private static global::System.Type _recyclingElementType = typeof(global::Infragistics.Controls.Grids.Primitives.RowSelectorCellControl);
	}
}
