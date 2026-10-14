using System;
using System.Windows.Forms;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x02000398 RID: 920
	internal class MouseCursor : global::SourceGrid.Cells.Controllers.ControllerBase
	{
		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x000917DC File Offset: 0x0008F9DC
		public static global::SourceGrid.Cells.Controllers.MouseCursor Default
		{
			get
			{
				if (global::SourceGrid.Cells.Controllers.MouseCursor.t_Default == null)
				{
					global::SourceGrid.Cells.Controllers.MouseCursor.t_Default = new global::SourceGrid.Cells.Controllers.MouseCursor(global::System.Windows.Forms.Cursors.Default, true);
				}
				return global::SourceGrid.Cells.Controllers.MouseCursor.t_Default;
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06002B29 RID: 11049 RVA: 0x00091800 File Offset: 0x0008FA00
		public static global::SourceGrid.Cells.Controllers.MouseCursor Hand
		{
			get
			{
				if (global::SourceGrid.Cells.Controllers.MouseCursor.t_Hand == null)
				{
					global::SourceGrid.Cells.Controllers.MouseCursor.t_Hand = new global::SourceGrid.Cells.Controllers.MouseCursor(global::System.Windows.Forms.Cursors.Hand, true);
				}
				return global::SourceGrid.Cells.Controllers.MouseCursor.t_Hand;
			}
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x00091824 File Offset: 0x0008FA24
		public MouseCursor(global::System.Windows.Forms.Cursor cursor, bool applyOnMouseEnter)
		{
			this.mApplyOnMouseEnter = applyOnMouseEnter;
			this.mCursor = cursor;
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x0009183C File Offset: 0x0008FA3C
		public override void OnMouseEnter(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnMouseEnter(sender, e);
			if (this.mApplyOnMouseEnter)
			{
				this.ApplyCursor(sender, e);
			}
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x0009185C File Offset: 0x0008FA5C
		public override void OnMouseLeave(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnMouseLeave(sender, e);
			if (this.mApplyOnMouseEnter)
			{
				this.ResetCursor(sender, e);
			}
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x0009187C File Offset: 0x0008FA7C
		public virtual void ApplyCursor(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			if (this.Cursor != null)
			{
				sender.Grid.Cursor = this.Cursor;
			}
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x000918A4 File Offset: 0x0008FAA4
		public virtual void ResetCursor(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			if (this.Cursor != null && sender.Grid.Cursor == this.Cursor)
			{
				sender.Grid.Cursor = null;
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06002B2F RID: 11055 RVA: 0x000918E0 File Offset: 0x0008FAE0
		// (set) Token: 0x06002B30 RID: 11056 RVA: 0x000918E8 File Offset: 0x0008FAE8
		public global::System.Windows.Forms.Cursor Cursor
		{
			get
			{
				return this.mCursor;
			}
			set
			{
				this.mCursor = value;
			}
		}

		// Token: 0x04000E85 RID: 3717
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Controllers.MouseCursor t_Default;

		// Token: 0x04000E86 RID: 3718
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Controllers.MouseCursor t_Hand;

		// Token: 0x04000E87 RID: 3719
		private bool mApplyOnMouseEnter;

		// Token: 0x04000E88 RID: 3720
		private global::System.Windows.Forms.Cursor mCursor;
	}
}
