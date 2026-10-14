using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevAge.Windows.Forms
{
	// Token: 0x020002D5 RID: 725
	internal class HeaderGroupBox : global::System.Windows.Forms.GroupBox
	{
		// Token: 0x0600234E RID: 9038 RVA: 0x0007B9FC File Offset: 0x00079BFC
		protected override void OnPaint(global::System.Windows.Forms.PaintEventArgs e)
		{
			global::System.Drawing.StringFormat stringFormat = new global::System.Drawing.StringFormat();
			stringFormat.Trimming = global::System.Drawing.StringTrimming.Character;
			stringFormat.Alignment = global::System.Drawing.StringAlignment.Near;
			if (this.RightToLeft == global::System.Windows.Forms.RightToLeft.Yes)
			{
				stringFormat.FormatFlags |= global::System.Drawing.StringFormatFlags.DirectionRightToLeft;
			}
			global::System.Drawing.SizeF sizeF = e.Graphics.MeasureString(this.Text, this.Font, base.ClientRectangle.Size, stringFormat);
			if (base.Enabled)
			{
				using (global::System.Drawing.Brush brush = new global::System.Drawing.SolidBrush(this.ForeColor))
				{
					e.Graphics.DrawString(this.Text, this.Font, brush, base.ClientRectangle, stringFormat);
					goto IL_D0;
				}
			}
			global::System.Windows.Forms.ControlPaint.DrawStringDisabled(e.Graphics, this.Text, this.Font, this.BackColor, base.ClientRectangle, stringFormat);
			IL_D0:
			global::System.Drawing.Pen pen = new global::System.Drawing.Pen(global::System.Windows.Forms.ControlPaint.LightLight(this.BackColor), (float)global::System.Windows.Forms.SystemInformation.BorderSize.Height);
			global::System.Drawing.Pen pen2 = new global::System.Drawing.Pen(global::System.Windows.Forms.ControlPaint.Dark(this.BackColor), (float)global::System.Windows.Forms.SystemInformation.BorderSize.Height);
			global::System.Drawing.Point pt = new global::System.Drawing.Point(base.ClientRectangle.Left, base.ClientRectangle.Top + (int)((float)this.Font.Height / 2f));
			global::System.Drawing.Point pt2 = new global::System.Drawing.Point(base.ClientRectangle.Right, base.ClientRectangle.Top + (int)((float)this.Font.Height / 2f));
			if (this.RightToLeft != global::System.Windows.Forms.RightToLeft.Yes)
			{
				pt.X += (int)sizeF.Width;
				if (this.m_Image != null)
				{
					pt2.X -= 17;
				}
				if (this.m_Image != null)
				{
					e.Graphics.DrawImage(this.m_Image, pt2.X + 1, 0, 16, 16);
				}
			}
			else
			{
				pt2.X -= (int)sizeF.Width;
				if (this.m_Image != null)
				{
					pt.X += 17;
				}
				if (this.m_Image != null)
				{
					e.Graphics.DrawImage(this.m_Image, 0, 0, 16, 16);
				}
			}
			if (base.FlatStyle == global::System.Windows.Forms.FlatStyle.Flat)
			{
				e.Graphics.DrawLine(pen2, pt, pt2);
			}
			else
			{
				e.Graphics.DrawLine(pen2, pt, pt2);
				pt.Offset(0, (int)global::System.Math.Ceiling((double)((float)global::System.Windows.Forms.SystemInformation.BorderSize.Height / 2f)));
				pt2.Offset(0, (int)global::System.Math.Ceiling((double)((float)global::System.Windows.Forms.SystemInformation.BorderSize.Height / 2f)));
				e.Graphics.DrawLine(pen, pt, pt2);
			}
			pen.Dispose();
			pen2.Dispose();
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x0007BCF8 File Offset: 0x00079EF8
		// (set) Token: 0x06002350 RID: 9040 RVA: 0x0007BD00 File Offset: 0x00079F00
		public global::System.Drawing.Image Image
		{
			get
			{
				return this.m_Image;
			}
			set
			{
				this.m_Image = value;
			}
		}

		// Token: 0x04000C93 RID: 3219
		private global::System.Drawing.Image m_Image;
	}
}
