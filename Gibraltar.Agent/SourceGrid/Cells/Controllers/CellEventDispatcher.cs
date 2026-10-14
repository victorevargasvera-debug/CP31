using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevAge.ComponentModel;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x02000353 RID: 851
	internal class CellEventDispatcher : global::SourceGrid.Cells.Controllers.ControllerBase
	{
		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x0600299C RID: 10652 RVA: 0x0008EDBC File Offset: 0x0008CFBC
		public static global::SourceGrid.Cells.Controllers.CellEventDispatcher Default
		{
			get
			{
				if (global::SourceGrid.Cells.Controllers.CellEventDispatcher.t_Default == null)
				{
					global::SourceGrid.Cells.Controllers.CellEventDispatcher.t_Default = new global::SourceGrid.Cells.Controllers.CellEventDispatcher();
				}
				return global::SourceGrid.Cells.Controllers.CellEventDispatcher.t_Default;
			}
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x0008EDD8 File Offset: 0x0008CFD8
		public override void OnKeyDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyEventArgs e)
		{
			base.OnKeyDown(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null && !e.Handled)
			{
				sender.Cell.Controller.OnKeyDown(sender, e);
			}
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x0008EE2C File Offset: 0x0008D02C
		public override void OnKeyPress(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyPressEventArgs e)
		{
			base.OnKeyPress(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null && !e.Handled)
			{
				sender.Cell.Controller.OnKeyPress(sender, e);
			}
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x0008EE80 File Offset: 0x0008D080
		public override void OnDoubleClick(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnDoubleClick(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnDoubleClick(sender, e);
			}
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x0008EEBC File Offset: 0x0008D0BC
		public override void OnClick(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnClick(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnClick(sender, e);
			}
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x0008EEF8 File Offset: 0x0008D0F8
		public override void OnFocusEntered(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnFocusEntered(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnFocusEntered(sender, e);
			}
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x0008EF34 File Offset: 0x0008D134
		public override void OnFocusLeft(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnFocusLeft(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnFocusLeft(sender, e);
			}
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x0008EF70 File Offset: 0x0008D170
		public override void OnValueChanged(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnValueChanged(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnValueChanged(sender, e);
			}
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x0008EFAC File Offset: 0x0008D1AC
		public override void OnEditEnded(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnEditEnded(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnEditEnded(sender, e);
			}
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x0008EFE8 File Offset: 0x0008D1E8
		public override bool CanReceiveFocus(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			return base.CanReceiveFocus(sender, e) && sender.Cell != null && (sender.Cell.Controller == null || sender.Cell.Controller.CanReceiveFocus(sender, e));
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x0008F040 File Offset: 0x0008D240
		public override void OnEditStarting(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e)
		{
			base.OnEditStarting(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnEditStarting(sender, e);
			}
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x0008F07C File Offset: 0x0008D27C
		public override void OnEditStarted(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnEditStarted(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnEditStarted(sender, e);
			}
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x0008F0B8 File Offset: 0x0008D2B8
		public override void OnValueChanging(global::SourceGrid.CellContext sender, global::DevAge.ComponentModel.ValueEventArgs e)
		{
			base.OnValueChanging(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnValueChanging(sender, e);
			}
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x0008F0F4 File Offset: 0x0008D2F4
		public override void OnFocusEntering(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e)
		{
			base.OnFocusEntering(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnFocusEntering(sender, e);
			}
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x0008F130 File Offset: 0x0008D330
		public override void OnFocusLeaving(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e)
		{
			base.OnFocusLeaving(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnFocusLeaving(sender, e);
			}
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x0008F16C File Offset: 0x0008D36C
		public override void OnKeyUp(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyEventArgs e)
		{
			base.OnKeyUp(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnKeyUp(sender, e);
			}
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x0008F1A8 File Offset: 0x0008D3A8
		public override void OnMouseDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseDown(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnMouseDown(sender, e);
			}
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x0008F1E4 File Offset: 0x0008D3E4
		public override void OnMouseEnter(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnMouseEnter(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnMouseEnter(sender, e);
			}
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x0008F220 File Offset: 0x0008D420
		public override void OnMouseLeave(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnMouseLeave(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnMouseLeave(sender, e);
			}
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x0008F25C File Offset: 0x0008D45C
		public override void OnMouseMove(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseMove(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnMouseMove(sender, e);
			}
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x0008F298 File Offset: 0x0008D498
		public override void OnMouseUp(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseUp(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnMouseUp(sender, e);
			}
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x0008F2D4 File Offset: 0x0008D4D4
		public override void OnDragDrop(global::SourceGrid.CellContext sender, global::System.Windows.Forms.DragEventArgs e)
		{
			base.OnDragDrop(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnDragDrop(sender, e);
			}
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x0008F310 File Offset: 0x0008D510
		public override void OnDragEnter(global::SourceGrid.CellContext sender, global::System.Windows.Forms.DragEventArgs e)
		{
			base.OnDragEnter(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnDragEnter(sender, e);
			}
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x0008F34C File Offset: 0x0008D54C
		public override void OnDragLeave(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnDragLeave(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnDragLeave(sender, e);
			}
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x0008F388 File Offset: 0x0008D588
		public override void OnDragOver(global::SourceGrid.CellContext sender, global::System.Windows.Forms.DragEventArgs e)
		{
			base.OnDragOver(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnDragOver(sender, e);
			}
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x0008F3C4 File Offset: 0x0008D5C4
		public override void OnGiveFeedback(global::SourceGrid.CellContext sender, global::System.Windows.Forms.GiveFeedbackEventArgs e)
		{
			base.OnGiveFeedback(sender, e);
			if (sender.Cell != null && sender.Cell.Controller != null)
			{
				sender.Cell.Controller.OnGiveFeedback(sender, e);
			}
		}

		// Token: 0x04000E32 RID: 3634
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Controllers.CellEventDispatcher t_Default;
	}
}
