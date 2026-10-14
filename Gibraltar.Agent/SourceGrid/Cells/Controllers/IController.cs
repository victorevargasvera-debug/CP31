using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevAge.ComponentModel;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x0200034A RID: 842
	internal interface IController
	{
		// Token: 0x060028E5 RID: 10469
		void OnMouseDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e);

		// Token: 0x060028E6 RID: 10470
		void OnMouseUp(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e);

		// Token: 0x060028E7 RID: 10471
		void OnMouseMove(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e);

		// Token: 0x060028E8 RID: 10472
		void OnMouseEnter(global::SourceGrid.CellContext sender, global::System.EventArgs e);

		// Token: 0x060028E9 RID: 10473
		void OnMouseLeave(global::SourceGrid.CellContext sender, global::System.EventArgs e);

		// Token: 0x060028EA RID: 10474
		void OnKeyUp(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyEventArgs e);

		// Token: 0x060028EB RID: 10475
		void OnKeyDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyEventArgs e);

		// Token: 0x060028EC RID: 10476
		void OnKeyPress(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyPressEventArgs e);

		// Token: 0x060028ED RID: 10477
		void OnDoubleClick(global::SourceGrid.CellContext sender, global::System.EventArgs e);

		// Token: 0x060028EE RID: 10478
		void OnClick(global::SourceGrid.CellContext sender, global::System.EventArgs e);

		// Token: 0x060028EF RID: 10479
		void OnFocusLeaving(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e);

		// Token: 0x060028F0 RID: 10480
		void OnFocusLeft(global::SourceGrid.CellContext sender, global::System.EventArgs e);

		// Token: 0x060028F1 RID: 10481
		void OnFocusEntering(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e);

		// Token: 0x060028F2 RID: 10482
		void OnFocusEntered(global::SourceGrid.CellContext sender, global::System.EventArgs e);

		// Token: 0x060028F3 RID: 10483
		void OnValueChanging(global::SourceGrid.CellContext sender, global::DevAge.ComponentModel.ValueEventArgs e);

		// Token: 0x060028F4 RID: 10484
		void OnValueChanged(global::SourceGrid.CellContext sender, global::System.EventArgs e);

		// Token: 0x060028F5 RID: 10485
		void OnEditStarting(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e);

		// Token: 0x060028F6 RID: 10486
		void OnEditStarted(global::SourceGrid.CellContext sender, global::System.EventArgs e);

		// Token: 0x060028F7 RID: 10487
		void OnEditEnded(global::SourceGrid.CellContext sender, global::System.EventArgs e);

		// Token: 0x060028F8 RID: 10488
		bool CanReceiveFocus(global::SourceGrid.CellContext sender, global::System.EventArgs e);

		// Token: 0x060028F9 RID: 10489
		void OnDragDrop(global::SourceGrid.CellContext sender, global::System.Windows.Forms.DragEventArgs e);

		// Token: 0x060028FA RID: 10490
		void OnDragEnter(global::SourceGrid.CellContext sender, global::System.Windows.Forms.DragEventArgs e);

		// Token: 0x060028FB RID: 10491
		void OnDragLeave(global::SourceGrid.CellContext sender, global::System.EventArgs e);

		// Token: 0x060028FC RID: 10492
		void OnDragOver(global::SourceGrid.CellContext sender, global::System.Windows.Forms.DragEventArgs e);

		// Token: 0x060028FD RID: 10493
		void OnGiveFeedback(global::SourceGrid.CellContext sender, global::System.Windows.Forms.GiveFeedbackEventArgs e);
	}
}
