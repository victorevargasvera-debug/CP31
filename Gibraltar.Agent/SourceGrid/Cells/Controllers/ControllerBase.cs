using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevAge.ComponentModel;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x0200034C RID: 844
	internal abstract class ControllerBase : global::SourceGrid.Cells.Controllers.IController
	{
		// Token: 0x06002948 RID: 10568 RVA: 0x0008DE7C File Offset: 0x0008C07C
		public virtual void OnMouseDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x0008DE80 File Offset: 0x0008C080
		public virtual void OnMouseUp(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x0008DE84 File Offset: 0x0008C084
		public virtual void OnMouseMove(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x0008DE88 File Offset: 0x0008C088
		public virtual void OnMouseEnter(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x0008DE8C File Offset: 0x0008C08C
		public virtual void OnMouseLeave(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x0008DE90 File Offset: 0x0008C090
		public virtual void OnKeyUp(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyEventArgs e)
		{
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x0008DE94 File Offset: 0x0008C094
		public virtual void OnKeyDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyEventArgs e)
		{
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x0008DE98 File Offset: 0x0008C098
		public virtual void OnKeyPress(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyPressEventArgs e)
		{
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x0008DE9C File Offset: 0x0008C09C
		public virtual void OnDoubleClick(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x0008DEA0 File Offset: 0x0008C0A0
		public virtual void OnClick(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x0008DEA4 File Offset: 0x0008C0A4
		public virtual void OnFocusLeaving(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e)
		{
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x0008DEA8 File Offset: 0x0008C0A8
		public virtual void OnFocusLeft(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x0008DEAC File Offset: 0x0008C0AC
		public virtual void OnFocusEntering(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e)
		{
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x0008DEB0 File Offset: 0x0008C0B0
		public virtual void OnFocusEntered(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x0008DEB4 File Offset: 0x0008C0B4
		public virtual void OnValueChanging(global::SourceGrid.CellContext sender, global::DevAge.ComponentModel.ValueEventArgs e)
		{
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x0008DEB8 File Offset: 0x0008C0B8
		public virtual void OnValueChanged(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x0008DEBC File Offset: 0x0008C0BC
		public virtual void OnEditStarting(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e)
		{
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x0008DEC0 File Offset: 0x0008C0C0
		public virtual void OnEditStarted(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x0008DEC4 File Offset: 0x0008C0C4
		public virtual void OnEditEnded(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x0008DEC8 File Offset: 0x0008C0C8
		public virtual bool CanReceiveFocus(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			return true;
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x0008DECC File Offset: 0x0008C0CC
		public virtual void OnDragDrop(global::SourceGrid.CellContext sender, global::System.Windows.Forms.DragEventArgs e)
		{
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x0008DED0 File Offset: 0x0008C0D0
		public virtual void OnDragEnter(global::SourceGrid.CellContext sender, global::System.Windows.Forms.DragEventArgs e)
		{
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x0008DED4 File Offset: 0x0008C0D4
		public virtual void OnDragLeave(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x0008DED8 File Offset: 0x0008C0D8
		public virtual void OnDragOver(global::SourceGrid.CellContext sender, global::System.Windows.Forms.DragEventArgs e)
		{
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x0008DEDC File Offset: 0x0008C0DC
		public virtual void OnGiveFeedback(global::SourceGrid.CellContext sender, global::System.Windows.Forms.GiveFeedbackEventArgs e)
		{
		}
	}
}
