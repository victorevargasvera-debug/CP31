using System;
using System.ComponentModel;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x020003B7 RID: 951
	internal class Unselectable : global::SourceGrid.Cells.Controllers.ControllerBase
	{
		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002B99 RID: 11161 RVA: 0x00092594 File Offset: 0x00090794
		public static global::SourceGrid.Cells.Controllers.Unselectable Default
		{
			get
			{
				if (global::SourceGrid.Cells.Controllers.Unselectable.t_Default == null)
				{
					global::SourceGrid.Cells.Controllers.Unselectable.t_Default = new global::SourceGrid.Cells.Controllers.Unselectable();
				}
				return global::SourceGrid.Cells.Controllers.Unselectable.t_Default;
			}
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x000925B0 File Offset: 0x000907B0
		public override void OnFocusEntering(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e)
		{
			base.OnFocusEntering(sender, e);
			e.Cancel = !this.CanReceiveFocus(sender, e);
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x000925CC File Offset: 0x000907CC
		public override bool CanReceiveFocus(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			return false;
		}

		// Token: 0x04000E9C RID: 3740
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Controllers.Unselectable t_Default;
	}
}
