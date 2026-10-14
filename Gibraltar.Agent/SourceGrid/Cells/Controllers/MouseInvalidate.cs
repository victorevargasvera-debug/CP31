using System;
using System.Windows.Forms;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x020003C4 RID: 964
	internal class MouseInvalidate : global::SourceGrid.Cells.Controllers.ControllerBase
	{
		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06002C02 RID: 11266 RVA: 0x00093BAC File Offset: 0x00091DAC
		public static global::SourceGrid.Cells.Controllers.MouseInvalidate Default
		{
			get
			{
				if (global::SourceGrid.Cells.Controllers.MouseInvalidate.t_Default == null)
				{
					global::SourceGrid.Cells.Controllers.MouseInvalidate.t_Default = new global::SourceGrid.Cells.Controllers.MouseInvalidate();
				}
				return global::SourceGrid.Cells.Controllers.MouseInvalidate.t_Default;
			}
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x00093BD0 File Offset: 0x00091DD0
		public override void OnMouseDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseDown(sender, e);
			sender.Grid.InvalidateCell(sender.Position);
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x00093BF0 File Offset: 0x00091DF0
		public override void OnMouseUp(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseUp(sender, e);
			sender.Grid.InvalidateCell(sender.Position);
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x00093C10 File Offset: 0x00091E10
		public override void OnMouseEnter(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnMouseEnter(sender, e);
			sender.Grid.InvalidateCell(sender.Position);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x00093C30 File Offset: 0x00091E30
		public override void OnMouseLeave(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnMouseLeave(sender, e);
			sender.Grid.InvalidateCell(sender.Position);
		}

		// Token: 0x04000EAD RID: 3757
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Controllers.MouseInvalidate t_Default;
	}
}
