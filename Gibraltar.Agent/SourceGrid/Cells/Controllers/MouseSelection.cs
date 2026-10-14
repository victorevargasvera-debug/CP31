using System;
using System.Drawing;
using System.Windows.Forms;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x020003C5 RID: 965
	internal class MouseSelection : global::SourceGrid.Cells.Controllers.ControllerBase
	{
		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06002C08 RID: 11272 RVA: 0x00093C50 File Offset: 0x00091E50
		public static global::SourceGrid.Cells.Controllers.MouseSelection Default
		{
			get
			{
				if (global::SourceGrid.Cells.Controllers.MouseSelection.t_DefaultSelection == null)
				{
					global::SourceGrid.Cells.Controllers.MouseSelection.t_DefaultSelection = new global::SourceGrid.Cells.Controllers.MouseSelection();
				}
				return global::SourceGrid.Cells.Controllers.MouseSelection.t_DefaultSelection;
			}
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x00093C6C File Offset: 0x00091E6C
		public override void OnMouseDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseDown(sender, e);
			if (e.Button != global::System.Windows.Forms.MouseButtons.Left)
			{
				return;
			}
			global::SourceGrid.GridVirtual grid = sender.Grid;
			bool flag = (global::System.Windows.Forms.Control.ModifierKeys & global::System.Windows.Forms.Keys.Control) == global::System.Windows.Forms.Keys.Control && (grid.SpecialKeys & global::SourceGrid.GridSpecialKeys.Control) == global::SourceGrid.GridSpecialKeys.Control;
			bool flag2 = (global::System.Windows.Forms.Control.ModifierKeys & global::System.Windows.Forms.Keys.Shift) == global::System.Windows.Forms.Keys.Shift && (grid.SpecialKeys & global::SourceGrid.GridSpecialKeys.Shift) == global::SourceGrid.GridSpecialKeys.Shift;
			if (!flag2 || !grid.Selection.EnableMultiSelection)
			{
				bool flag3 = grid.Selection.EnableMultiSelection && flag;
				grid.Selection.Focus(sender.Position, !flag3);
				return;
			}
			grid.Selection.ResetSelection(true);
			global::SourceGrid.Range range = new global::SourceGrid.Range(grid.Selection.ActivePosition, sender.Position);
			grid.Selection.SelectRange(range, true);
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x00093D78 File Offset: 0x00091F78
		public override void OnMouseUp(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseUp(sender, e);
			sender.Grid.MouseSelectionFinish();
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x00093D90 File Offset: 0x00091F90
		public override void OnMouseMove(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseMove(sender, e);
			if (!sender.Grid.Selection.EnableMultiSelection || sender.Grid.MouseDownPosition.IsEmpty() || sender.Grid.MouseDownPosition != sender.Grid.Selection.ActivePosition)
			{
				return;
			}
			global::SourceGrid.Position position = sender.Grid.PositionAtPoint(new global::System.Drawing.Point(e.X, e.Y));
			if (position.IsEmpty())
			{
				return;
			}
			if (sender.Grid.GetPositionType(position) != sender.Grid.GetPositionType(sender.Grid.Selection.ActivePosition))
			{
				return;
			}
			sender.Grid.ChangeMouseSelectionCorner(position);
		}

		// Token: 0x04000EAE RID: 3758
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Controllers.MouseSelection t_DefaultSelection;
	}
}
