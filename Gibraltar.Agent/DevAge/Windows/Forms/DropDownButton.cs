using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevAge.Drawing;
using DevAge.Drawing.VisualElements;

namespace DevAge.Windows.Forms
{
	// Token: 0x0200030A RID: 778
	[global::System.ComponentModel.DefaultEvent("Click")]
	internal class DropDownButton : global::System.Windows.Forms.Control
	{
		// Token: 0x06002524 RID: 9508 RVA: 0x00081F1C File Offset: 0x0008011C
		public DropDownButton()
		{
			this.InitializeComponent();
			base.SetStyle(global::System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.UserMouse, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.UserPaint, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.DoubleBuffer, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.ResizeRedraw, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.Selectable, false);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.StandardClick, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.StandardDoubleClick, true);
			base.BackColor = global::System.Drawing.Color.Transparent;
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x00081FB4 File Offset: 0x000801B4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x00081FDC File Offset: 0x000801DC
		private void InitializeComponent()
		{
			base.Name = "DropDownButton";
			base.Size = new global::System.Drawing.Size(72, 24);
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x00081FF8 File Offset: 0x000801F8
		protected override void OnPaint(global::System.Windows.Forms.PaintEventArgs e)
		{
			base.OnPaint(e);
			if (base.Enabled)
			{
				if (this.m_Pressed)
				{
					this.mDropDown.Style = global::DevAge.Drawing.ButtonStyle.Pressed;
				}
				else if (this.m_MouseOver)
				{
					this.mDropDown.Style = global::DevAge.Drawing.ButtonStyle.Hot;
				}
				else
				{
					this.mDropDown.Style = global::DevAge.Drawing.ButtonStyle.Normal;
				}
			}
			else
			{
				this.mDropDown.Style = global::DevAge.Drawing.ButtonStyle.Disabled;
			}
			using (global::DevAge.Drawing.GraphicsCache graphicsCache = new global::DevAge.Drawing.GraphicsCache(e.Graphics, e.ClipRectangle))
			{
				this.mDropDown.Draw(graphicsCache, global::System.Drawing.Rectangle.Round(base.ClientRectangle));
			}
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x000820C4 File Offset: 0x000802C4
		protected override void OnMouseEnter(global::System.EventArgs e)
		{
			base.OnMouseEnter(e);
			this.m_MouseOver = true;
			base.Invalidate();
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x000820DC File Offset: 0x000802DC
		protected override void OnMouseLeave(global::System.EventArgs e)
		{
			base.OnMouseLeave(e);
			this.m_MouseOver = false;
			base.Invalidate();
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x000820F4 File Offset: 0x000802F4
		protected override void OnMouseDown(global::System.Windows.Forms.MouseEventArgs e)
		{
			this.m_Pressed = true;
			base.Invalidate();
			base.OnMouseDown(e);
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x0008210C File Offset: 0x0008030C
		protected override void OnMouseUp(global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.m_Pressed = false;
			base.Invalidate();
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x00082124 File Offset: 0x00080324
		protected override void OnKeyDown(global::System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == global::System.Windows.Forms.Keys.Space)
			{
				this.m_Pressed = true;
				this.OnClick(global::System.EventArgs.Empty);
				e.Handled = true;
			}
			base.OnKeyDown(e);
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x00082154 File Offset: 0x00080354
		protected override void OnKeyUp(global::System.Windows.Forms.KeyEventArgs e)
		{
			this.m_Pressed = false;
			base.Invalidate();
			base.OnKeyUp(e);
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x0008216C File Offset: 0x0008036C
		protected override void OnClick(global::System.EventArgs e)
		{
			base.OnClick(e);
			base.Invalidate();
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x0008217C File Offset: 0x0008037C
		// (set) Token: 0x06002530 RID: 9520 RVA: 0x00082184 File Offset: 0x00080384
		[global::System.ComponentModel.Browsable(false)]
		public new global::System.Drawing.Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor = value;
			}
		}

		// Token: 0x04000CF6 RID: 3318
		private global::System.ComponentModel.Container components;

		// Token: 0x04000CF7 RID: 3319
		private global::DevAge.Drawing.VisualElements.DropDownButtonThemed mDropDown = new global::DevAge.Drawing.VisualElements.DropDownButtonThemed();

		// Token: 0x04000CF8 RID: 3320
		private bool m_MouseOver;

		// Token: 0x04000CF9 RID: 3321
		private bool m_Pressed;
	}
}
