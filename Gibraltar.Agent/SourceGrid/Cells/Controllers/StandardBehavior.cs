using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x020003E1 RID: 993
	internal class StandardBehavior : global::SourceGrid.Cells.Controllers.ControllerBase
	{
		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06002C52 RID: 11346 RVA: 0x00094D84 File Offset: 0x00092F84
		public static global::SourceGrid.Cells.Controllers.StandardBehavior Default
		{
			get
			{
				if (global::SourceGrid.Cells.Controllers.StandardBehavior.t_Default == null)
				{
					global::SourceGrid.Cells.Controllers.StandardBehavior.t_Default = new global::SourceGrid.Cells.Controllers.StandardBehavior();
				}
				return global::SourceGrid.Cells.Controllers.StandardBehavior.t_Default;
			}
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x00094DA0 File Offset: 0x00092FA0
		public override void OnKeyDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyEventArgs e)
		{
			base.OnKeyDown(sender, e);
			if (e.KeyCode == global::System.Windows.Forms.Keys.F2 && sender.Cell.Editor != null && (sender.Cell.Editor.EditableMode & global::SourceGrid.EditableMode.F2Key) == global::SourceGrid.EditableMode.F2Key)
			{
				e.Handled = true;
				sender.StartEdit();
			}
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00094E00 File Offset: 0x00093000
		public override void OnKeyPress(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyPressEventArgs e)
		{
			base.OnKeyPress(sender, e);
			if (sender.Cell.Editor != null && (sender.Cell.Editor.EditableMode & global::SourceGrid.EditableMode.AnyKey) == global::SourceGrid.EditableMode.AnyKey && !sender.IsEditing() && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
				sender.StartEdit();
				sender.Cell.Editor.SendCharToEditor(e.KeyChar);
			}
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x00094E88 File Offset: 0x00093088
		public override void OnDoubleClick(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnDoubleClick(sender, e);
			if (sender.Cell.Editor != null && (sender.Cell.Editor.EditableMode & global::SourceGrid.EditableMode.DoubleClick) == global::SourceGrid.EditableMode.DoubleClick && sender.Grid.Selection.ActivePosition == sender.Position)
			{
				sender.StartEdit();
			}
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x00094EF4 File Offset: 0x000930F4
		public override void OnClick(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnClick(sender, e);
			if (sender.Cell.Editor != null && (sender.Cell.Editor.EditableMode & global::SourceGrid.EditableMode.SingleClick) == global::SourceGrid.EditableMode.SingleClick && sender.Grid.Selection.ActivePosition == sender.Position)
			{
				sender.StartEdit();
			}
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x00094F60 File Offset: 0x00093160
		public override void OnFocusEntered(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnFocusEntered(sender, e);
			sender.Grid.ShowCell(sender.Position, true);
			if (sender.Cell.Editor != null && (sender.Cell.Editor.EditableMode & global::SourceGrid.EditableMode.Focus) == global::SourceGrid.EditableMode.Focus)
			{
				sender.StartEdit();
			}
			if (sender.Grid != null)
			{
				sender.Grid.InvalidateCell(sender.Position);
			}
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x00094FE0 File Offset: 0x000931E0
		public override void OnFocusLeft(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnFocusLeft(sender, e);
			if (sender.Grid != null)
			{
				sender.Grid.InvalidateCell(sender.Position);
			}
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x0009500C File Offset: 0x0009320C
		public override void OnValueChanged(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnValueChanged(sender, e);
			if (sender.Grid != null)
			{
				sender.Grid.InvalidateCell(sender.Position);
			}
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x00095038 File Offset: 0x00093238
		public override void OnEditEnded(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnEditEnded(sender, e);
			sender.Grid.Selection.Invalidate();
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x00095054 File Offset: 0x00093254
		public override void OnEditStarting(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e)
		{
			base.OnEditStarting(sender, e);
			sender.Grid.Selection.Invalidate();
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x00095070 File Offset: 0x00093270
		public override bool CanReceiveFocus(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			return sender.Grid.Columns.IsColumnVisible(sender.Position.Column) && sender.Grid.Rows.IsRowVisible(sender.Position.Row) && base.CanReceiveFocus(sender, e);
		}

		// Token: 0x04000F15 RID: 3861
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Controllers.StandardBehavior t_Default;
	}
}
