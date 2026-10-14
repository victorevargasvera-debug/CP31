using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevAge.ComponentModel;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x0200034B RID: 843
	internal class CustomEvents : global::SourceGrid.Cells.Controllers.IController
	{
		// Token: 0x140000BF RID: 191
		// (add) Token: 0x060028FE RID: 10494 RVA: 0x0008D630 File Offset: 0x0008B830
		// (remove) Token: 0x060028FF RID: 10495 RVA: 0x0008D64C File Offset: 0x0008B84C
		public event global::System.Windows.Forms.MouseEventHandler MouseDown;

		// Token: 0x06002900 RID: 10496 RVA: 0x0008D668 File Offset: 0x0008B868
		public void OnMouseDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			if (this.MouseDown != null)
			{
				this.MouseDown(sender, e);
			}
		}

		// Token: 0x140000C0 RID: 192
		// (add) Token: 0x06002901 RID: 10497 RVA: 0x0008D688 File Offset: 0x0008B888
		// (remove) Token: 0x06002902 RID: 10498 RVA: 0x0008D6A4 File Offset: 0x0008B8A4
		public event global::System.Windows.Forms.MouseEventHandler MouseUp;

		// Token: 0x06002903 RID: 10499 RVA: 0x0008D6C0 File Offset: 0x0008B8C0
		public void OnMouseUp(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			if (this.MouseUp != null)
			{
				this.MouseUp(sender, e);
			}
		}

		// Token: 0x140000C1 RID: 193
		// (add) Token: 0x06002904 RID: 10500 RVA: 0x0008D6E0 File Offset: 0x0008B8E0
		// (remove) Token: 0x06002905 RID: 10501 RVA: 0x0008D6FC File Offset: 0x0008B8FC
		public event global::System.Windows.Forms.MouseEventHandler MouseMove;

		// Token: 0x06002906 RID: 10502 RVA: 0x0008D718 File Offset: 0x0008B918
		public void OnMouseMove(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			if (this.MouseMove != null)
			{
				this.MouseMove(sender, e);
			}
		}

		// Token: 0x140000C2 RID: 194
		// (add) Token: 0x06002907 RID: 10503 RVA: 0x0008D738 File Offset: 0x0008B938
		// (remove) Token: 0x06002908 RID: 10504 RVA: 0x0008D754 File Offset: 0x0008B954
		public event global::System.EventHandler MouseEnter;

		// Token: 0x06002909 RID: 10505 RVA: 0x0008D770 File Offset: 0x0008B970
		public void OnMouseEnter(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			if (this.MouseEnter != null)
			{
				this.MouseEnter(sender, e);
			}
		}

		// Token: 0x140000C3 RID: 195
		// (add) Token: 0x0600290A RID: 10506 RVA: 0x0008D790 File Offset: 0x0008B990
		// (remove) Token: 0x0600290B RID: 10507 RVA: 0x0008D7AC File Offset: 0x0008B9AC
		public event global::System.EventHandler MouseLeave;

		// Token: 0x0600290C RID: 10508 RVA: 0x0008D7C8 File Offset: 0x0008B9C8
		public void OnMouseLeave(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			if (this.MouseLeave != null)
			{
				this.MouseLeave(sender, e);
			}
		}

		// Token: 0x140000C4 RID: 196
		// (add) Token: 0x0600290D RID: 10509 RVA: 0x0008D7E8 File Offset: 0x0008B9E8
		// (remove) Token: 0x0600290E RID: 10510 RVA: 0x0008D804 File Offset: 0x0008BA04
		public event global::System.Windows.Forms.KeyEventHandler KeyUp;

		// Token: 0x0600290F RID: 10511 RVA: 0x0008D820 File Offset: 0x0008BA20
		public void OnKeyUp(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyEventArgs e)
		{
			if (this.KeyUp != null)
			{
				this.KeyUp(sender, e);
			}
		}

		// Token: 0x140000C5 RID: 197
		// (add) Token: 0x06002910 RID: 10512 RVA: 0x0008D840 File Offset: 0x0008BA40
		// (remove) Token: 0x06002911 RID: 10513 RVA: 0x0008D85C File Offset: 0x0008BA5C
		public event global::System.Windows.Forms.KeyEventHandler KeyDown;

		// Token: 0x06002912 RID: 10514 RVA: 0x0008D878 File Offset: 0x0008BA78
		public void OnKeyDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyEventArgs e)
		{
			if (this.KeyDown != null)
			{
				this.KeyDown(sender, e);
			}
		}

		// Token: 0x140000C6 RID: 198
		// (add) Token: 0x06002913 RID: 10515 RVA: 0x0008D898 File Offset: 0x0008BA98
		// (remove) Token: 0x06002914 RID: 10516 RVA: 0x0008D8B4 File Offset: 0x0008BAB4
		public event global::System.Windows.Forms.KeyPressEventHandler KeyPress;

		// Token: 0x06002915 RID: 10517 RVA: 0x0008D8D0 File Offset: 0x0008BAD0
		public void OnKeyPress(global::SourceGrid.CellContext sender, global::System.Windows.Forms.KeyPressEventArgs e)
		{
			if (this.KeyPress != null)
			{
				this.KeyPress(sender, e);
			}
		}

		// Token: 0x140000C7 RID: 199
		// (add) Token: 0x06002916 RID: 10518 RVA: 0x0008D8F0 File Offset: 0x0008BAF0
		// (remove) Token: 0x06002917 RID: 10519 RVA: 0x0008D90C File Offset: 0x0008BB0C
		public event global::System.EventHandler DoubleClick;

		// Token: 0x06002918 RID: 10520 RVA: 0x0008D928 File Offset: 0x0008BB28
		public void OnDoubleClick(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			if (this.DoubleClick != null)
			{
				this.DoubleClick(sender, e);
			}
		}

		// Token: 0x140000C8 RID: 200
		// (add) Token: 0x06002919 RID: 10521 RVA: 0x0008D948 File Offset: 0x0008BB48
		// (remove) Token: 0x0600291A RID: 10522 RVA: 0x0008D964 File Offset: 0x0008BB64
		public event global::System.EventHandler Click;

		// Token: 0x0600291B RID: 10523 RVA: 0x0008D980 File Offset: 0x0008BB80
		public void OnClick(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			if (this.Click != null)
			{
				this.Click(sender, e);
			}
		}

		// Token: 0x140000C9 RID: 201
		// (add) Token: 0x0600291C RID: 10524 RVA: 0x0008D9A0 File Offset: 0x0008BBA0
		// (remove) Token: 0x0600291D RID: 10525 RVA: 0x0008D9BC File Offset: 0x0008BBBC
		public event global::System.ComponentModel.CancelEventHandler FocusLeaving;

		// Token: 0x0600291E RID: 10526 RVA: 0x0008D9D8 File Offset: 0x0008BBD8
		public void OnFocusLeaving(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e)
		{
			if (this.FocusLeaving != null)
			{
				this.FocusLeaving(sender, e);
			}
		}

		// Token: 0x140000CA RID: 202
		// (add) Token: 0x0600291F RID: 10527 RVA: 0x0008D9F8 File Offset: 0x0008BBF8
		// (remove) Token: 0x06002920 RID: 10528 RVA: 0x0008DA14 File Offset: 0x0008BC14
		public event global::System.EventHandler FocusLeft;

		// Token: 0x06002921 RID: 10529 RVA: 0x0008DA30 File Offset: 0x0008BC30
		public void OnFocusLeft(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			if (this.FocusLeft != null)
			{
				this.FocusLeft(sender, e);
			}
		}

		// Token: 0x140000CB RID: 203
		// (add) Token: 0x06002922 RID: 10530 RVA: 0x0008DA50 File Offset: 0x0008BC50
		// (remove) Token: 0x06002923 RID: 10531 RVA: 0x0008DA6C File Offset: 0x0008BC6C
		public event global::System.ComponentModel.CancelEventHandler FocusEntering;

		// Token: 0x06002924 RID: 10532 RVA: 0x0008DA88 File Offset: 0x0008BC88
		public void OnFocusEntering(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e)
		{
			if (this.FocusEntering != null)
			{
				this.FocusEntering(sender, e);
			}
		}

		// Token: 0x140000CC RID: 204
		// (add) Token: 0x06002925 RID: 10533 RVA: 0x0008DAA8 File Offset: 0x0008BCA8
		// (remove) Token: 0x06002926 RID: 10534 RVA: 0x0008DAC4 File Offset: 0x0008BCC4
		public event global::System.EventHandler FocusEntered;

		// Token: 0x06002927 RID: 10535 RVA: 0x0008DAE0 File Offset: 0x0008BCE0
		public void OnFocusEntered(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			if (this.FocusEntered != null)
			{
				this.FocusEntered(sender, e);
			}
		}

		// Token: 0x140000CD RID: 205
		// (add) Token: 0x06002928 RID: 10536 RVA: 0x0008DB00 File Offset: 0x0008BD00
		// (remove) Token: 0x06002929 RID: 10537 RVA: 0x0008DB1C File Offset: 0x0008BD1C
		public event global::DevAge.ComponentModel.ValueEventHandler ValueChanging;

		// Token: 0x0600292A RID: 10538 RVA: 0x0008DB38 File Offset: 0x0008BD38
		public void OnValueChanging(global::SourceGrid.CellContext sender, global::DevAge.ComponentModel.ValueEventArgs e)
		{
			if (this.ValueChanging != null)
			{
				this.ValueChanging(sender, e);
			}
		}

		// Token: 0x140000CE RID: 206
		// (add) Token: 0x0600292B RID: 10539 RVA: 0x0008DB58 File Offset: 0x0008BD58
		// (remove) Token: 0x0600292C RID: 10540 RVA: 0x0008DB74 File Offset: 0x0008BD74
		public event global::System.EventHandler ValueChanged;

		// Token: 0x0600292D RID: 10541 RVA: 0x0008DB90 File Offset: 0x0008BD90
		public void OnValueChanged(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			if (this.ValueChanged != null)
			{
				this.ValueChanged(sender, e);
			}
		}

		// Token: 0x140000CF RID: 207
		// (add) Token: 0x0600292E RID: 10542 RVA: 0x0008DBB0 File Offset: 0x0008BDB0
		// (remove) Token: 0x0600292F RID: 10543 RVA: 0x0008DBCC File Offset: 0x0008BDCC
		public event global::System.ComponentModel.CancelEventHandler EditStarting;

		// Token: 0x06002930 RID: 10544 RVA: 0x0008DBE8 File Offset: 0x0008BDE8
		public virtual void OnEditStarting(global::SourceGrid.CellContext sender, global::System.ComponentModel.CancelEventArgs e)
		{
			if (this.EditStarting != null)
			{
				this.EditStarting(sender, e);
			}
		}

		// Token: 0x140000D0 RID: 208
		// (add) Token: 0x06002931 RID: 10545 RVA: 0x0008DC08 File Offset: 0x0008BE08
		// (remove) Token: 0x06002932 RID: 10546 RVA: 0x0008DC24 File Offset: 0x0008BE24
		public event global::System.EventHandler EditStarted;

		// Token: 0x06002933 RID: 10547 RVA: 0x0008DC40 File Offset: 0x0008BE40
		public virtual void OnEditStarted(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			if (this.EditStarted != null)
			{
				this.EditStarted(sender, e);
			}
		}

		// Token: 0x140000D1 RID: 209
		// (add) Token: 0x06002934 RID: 10548 RVA: 0x0008DC60 File Offset: 0x0008BE60
		// (remove) Token: 0x06002935 RID: 10549 RVA: 0x0008DC7C File Offset: 0x0008BE7C
		public event global::System.EventHandler EditEnded;

		// Token: 0x06002936 RID: 10550 RVA: 0x0008DC98 File Offset: 0x0008BE98
		public virtual void OnEditEnded(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			if (this.EditEnded != null)
			{
				this.EditEnded(sender, e);
			}
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x0008DCB8 File Offset: 0x0008BEB8
		public virtual bool CanReceiveFocus(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			return true;
		}

		// Token: 0x140000D2 RID: 210
		// (add) Token: 0x06002938 RID: 10552 RVA: 0x0008DCBC File Offset: 0x0008BEBC
		// (remove) Token: 0x06002939 RID: 10553 RVA: 0x0008DCD8 File Offset: 0x0008BED8
		public event global::System.Windows.Forms.DragEventHandler DragDrop;

		// Token: 0x0600293A RID: 10554 RVA: 0x0008DCF4 File Offset: 0x0008BEF4
		public virtual void OnDragDrop(global::SourceGrid.CellContext sender, global::System.Windows.Forms.DragEventArgs e)
		{
			if (this.DragDrop != null)
			{
				this.DragDrop(sender, e);
			}
		}

		// Token: 0x140000D3 RID: 211
		// (add) Token: 0x0600293B RID: 10555 RVA: 0x0008DD14 File Offset: 0x0008BF14
		// (remove) Token: 0x0600293C RID: 10556 RVA: 0x0008DD30 File Offset: 0x0008BF30
		public event global::System.Windows.Forms.DragEventHandler DragEnter;

		// Token: 0x0600293D RID: 10557 RVA: 0x0008DD4C File Offset: 0x0008BF4C
		public virtual void OnDragEnter(global::SourceGrid.CellContext sender, global::System.Windows.Forms.DragEventArgs e)
		{
			if (this.DragEnter != null)
			{
				this.DragEnter(sender, e);
			}
		}

		// Token: 0x140000D4 RID: 212
		// (add) Token: 0x0600293E RID: 10558 RVA: 0x0008DD6C File Offset: 0x0008BF6C
		// (remove) Token: 0x0600293F RID: 10559 RVA: 0x0008DD88 File Offset: 0x0008BF88
		public event global::System.EventHandler DragLeave;

		// Token: 0x06002940 RID: 10560 RVA: 0x0008DDA4 File Offset: 0x0008BFA4
		public virtual void OnDragLeave(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			if (this.DragLeave != null)
			{
				this.DragLeave(sender, e);
			}
		}

		// Token: 0x140000D5 RID: 213
		// (add) Token: 0x06002941 RID: 10561 RVA: 0x0008DDC4 File Offset: 0x0008BFC4
		// (remove) Token: 0x06002942 RID: 10562 RVA: 0x0008DDE0 File Offset: 0x0008BFE0
		public event global::System.Windows.Forms.DragEventHandler DragOver;

		// Token: 0x06002943 RID: 10563 RVA: 0x0008DDFC File Offset: 0x0008BFFC
		public virtual void OnDragOver(global::SourceGrid.CellContext sender, global::System.Windows.Forms.DragEventArgs e)
		{
			if (this.DragOver != null)
			{
				this.DragOver(sender, e);
			}
		}

		// Token: 0x140000D6 RID: 214
		// (add) Token: 0x06002944 RID: 10564 RVA: 0x0008DE1C File Offset: 0x0008C01C
		// (remove) Token: 0x06002945 RID: 10565 RVA: 0x0008DE38 File Offset: 0x0008C038
		public event global::System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback;

		// Token: 0x06002946 RID: 10566 RVA: 0x0008DE54 File Offset: 0x0008C054
		public virtual void OnGiveFeedback(global::SourceGrid.CellContext sender, global::System.Windows.Forms.GiveFeedbackEventArgs e)
		{
			if (this.GiveFeedback != null)
			{
				this.GiveFeedback(sender, e);
			}
		}
	}
}
