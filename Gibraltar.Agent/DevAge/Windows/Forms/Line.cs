using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevAge.Windows.Forms
{
	// Token: 0x0200032B RID: 811
	internal class Line : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06002645 RID: 9797 RVA: 0x0008491C File Offset: 0x00082B1C
		public Line()
		{
			this.InitializeComponent();
			base.SetStyle(global::System.Windows.Forms.ControlStyles.UserPaint | global::System.Windows.Forms.ControlStyles.ResizeRedraw | global::System.Windows.Forms.ControlStyles.FixedWidth | global::System.Windows.Forms.ControlStyles.FixedHeight | global::System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.Selectable, false);
			base.TabStop = false;
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x00084978 File Offset: 0x00082B78
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x000849A0 File Offset: 0x00082BA0
		private void InitializeComponent()
		{
			base.Name = "Line";
			base.Size = new global::System.Drawing.Size(140, 140);
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x000849C4 File Offset: 0x00082BC4
		protected override void OnPaint(global::System.Windows.Forms.PaintEventArgs e)
		{
			base.OnPaint(e);
			int x;
			int y;
			int x2;
			int y2;
			int x3;
			int y3;
			int x4;
			int y4;
			if (this.LineStyle == global::DevAge.Windows.Forms.LineStyle.Horizontal)
			{
				x = 0;
				y = 0;
				x2 = base.ClientRectangle.Width;
				y2 = 0;
				x3 = 0;
				y3 = 1;
				x4 = base.ClientRectangle.Width;
				y4 = 1;
			}
			else
			{
				x = 0;
				y = 0;
				x2 = 0;
				y2 = base.ClientRectangle.Height;
				x3 = 1;
				y3 = 0;
				x4 = 1;
				y4 = base.ClientRectangle.Height;
			}
			using (global::System.Drawing.Pen pen = new global::System.Drawing.Pen(this.m_FirstColor, 1f))
			{
				pen.DashStyle = this.mDashStyle;
				e.Graphics.DrawLine(pen, x, y, x2, y2);
			}
			using (global::System.Drawing.Pen pen2 = new global::System.Drawing.Pen(this.m_SecondColor, 1f))
			{
				pen2.DashStyle = this.mDashStyle;
				e.Graphics.DrawLine(pen2, x3, y3, x4, y4);
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06002649 RID: 9801 RVA: 0x00084AF4 File Offset: 0x00082CF4
		// (set) Token: 0x0600264A RID: 9802 RVA: 0x00084AFC File Offset: 0x00082CFC
		public global::System.Drawing.Drawing2D.DashStyle DashStyle
		{
			get
			{
				return this.mDashStyle;
			}
			set
			{
				this.mDashStyle = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x0600264B RID: 9803 RVA: 0x00084B0C File Offset: 0x00082D0C
		// (set) Token: 0x0600264C RID: 9804 RVA: 0x00084B14 File Offset: 0x00082D14
		public global::System.Drawing.Color FirstColor
		{
			get
			{
				return this.m_FirstColor;
			}
			set
			{
				this.m_FirstColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x0600264D RID: 9805 RVA: 0x00084B24 File Offset: 0x00082D24
		// (set) Token: 0x0600264E RID: 9806 RVA: 0x00084B2C File Offset: 0x00082D2C
		public global::System.Drawing.Color SecondColor
		{
			get
			{
				return this.m_SecondColor;
			}
			set
			{
				this.m_SecondColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x0600264F RID: 9807 RVA: 0x00084B3C File Offset: 0x00082D3C
		// (set) Token: 0x06002650 RID: 9808 RVA: 0x00084B44 File Offset: 0x00082D44
		public global::DevAge.Windows.Forms.LineStyle LineStyle
		{
			get
			{
				return this.m_LineStyle;
			}
			set
			{
				this.m_LineStyle = value;
				base.Size = new global::System.Drawing.Size(base.Height, base.Width);
				base.Invalidate();
			}
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x00084B7C File Offset: 0x00082D7C
		protected override void OnSizeChanged(global::System.EventArgs e)
		{
			base.OnSizeChanged(e);
			this.ChangeControlSize();
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x00084B8C File Offset: 0x00082D8C
		private void ChangeControlSize()
		{
			if (this.LineStyle == global::DevAge.Windows.Forms.LineStyle.Horizontal)
			{
				base.Height = 2;
				return;
			}
			if (this.LineStyle == global::DevAge.Windows.Forms.LineStyle.Vertical)
			{
				base.Width = 2;
			}
		}

		// Token: 0x04000D79 RID: 3449
		private global::System.ComponentModel.Container components;

		// Token: 0x04000D7A RID: 3450
		private global::System.Drawing.Drawing2D.DashStyle mDashStyle;

		// Token: 0x04000D7B RID: 3451
		private global::System.Drawing.Color m_FirstColor = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.ControlDark);

		// Token: 0x04000D7C RID: 3452
		private global::System.Drawing.Color m_SecondColor = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.ControlLightLight);

		// Token: 0x04000D7D RID: 3453
		private global::DevAge.Windows.Forms.LineStyle m_LineStyle = global::DevAge.Windows.Forms.LineStyle.Horizontal;
	}
}
