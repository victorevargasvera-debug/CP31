using System;
using System.Windows.Forms;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x02000399 RID: 921
	internal class Button : global::SourceGrid.Cells.Controllers.ControllerBase
	{
		// Token: 0x06002B31 RID: 11057 RVA: 0x000918F4 File Offset: 0x0008FAF4
		public override void OnMouseDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseDown(sender, e);
			this.mLastButton = e.Button;
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x0009190C File Offset: 0x0008FB0C
		public override void OnClick(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnClick(sender, e);
			if (this.mLastButton == global::System.Windows.Forms.MouseButtons.Left)
			{
				this.OnExecuted(sender, e);
			}
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x00091930 File Offset: 0x0008FB30
		public override void OnKeyDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyEventArgs e)
		{
			base.OnKeyDown(sender, e);
			if (e.Handled)
			{
				return;
			}
			if (e.KeyCode == global::System.Windows.Forms.Keys.Space || e.KeyCode == global::System.Windows.Forms.Keys.Return)
			{
				this.OnExecuted(sender, e);
				e.Handled = true;
			}
		}

		// Token: 0x140000D7 RID: 215
		// (add) Token: 0x06002B34 RID: 11060 RVA: 0x00091980 File Offset: 0x0008FB80
		// (remove) Token: 0x06002B35 RID: 11061 RVA: 0x0009199C File Offset: 0x0008FB9C
		public event global::System.EventHandler Executed;

		// Token: 0x06002B36 RID: 11062 RVA: 0x000919B8 File Offset: 0x0008FBB8
		public virtual void OnExecuted(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			if (this.Executed != null)
			{
				this.Executed(sender, e);
			}
		}

		// Token: 0x04000E89 RID: 3721
		private global::System.Windows.Forms.MouseButtons mLastButton;
	}
}
